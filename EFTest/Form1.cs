using System;
using System.Linq;
using System.Windows.Forms;

namespace EFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axAcroPDF1.src = @"D:\项目资料\鑫亚\开发\操作手册\鑫亚软控上位机使用操作步骤.pdf";
            axBarCodeCtrl1.Value = "1234567";
            axBarCodeCtrl1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime begin = System.DateTime.Now;
            using (XinYaDBEntities db = new XinYaDBEntities())
            {
                //var b = db.TB_SystemLog.Select(p => new
                //{
                //    p.ID,
                //    p.Recorder,
                //    p.Source,
                //    p.SysLog,
                //    p.Time
                //}).ToList();
                var c = db.TB_WorkDtlForEachStation.ToList();
                var d =( from f in c.AsParallel()
                        select Change(f)).ToList();
                //var b = db.TB_SystemLog.Include("TB_User").ToList();
                //foreach (var item in b)
                //{
                //    item.TB_User;
                //}
                //dataGridView1.DataSource = b;
                //var a = db.TB_WorkMain.Select(p => new
                //{
                //    p.WorkID,
                //    p.TB_User.UserName,
                //    p.CreateDate
                //});
                //dataGridView1.DataSource = a.ToList();
            }
            DateTime end = System.DateTime.Now;
            label1.Text = (end - begin).ToString();
        }

        public TB_WorkDtlForEachStation Change(TB_WorkDtlForEachStation a)
        {
            a.Remark = a.Remark + "Suffix";
            int i = 0;
            while (i < 100000)
                i++;
            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (XinYaDBEntities db = new XinYaDBEntities())
            {
                var a = db.TB_WorkMain.GroupBy(p => p.Creator).ToList();
                var b = (from c in db.TB_WorkMain
                         from d in c.TB_WorkDtl
                         where d.CreateDate > new DateTime(2015, 7, 1) && c.CreateDate > new DateTime(2015, 7, 1)
                         select d).ToList();
                //这条语句可以达到与上述linq相同的结果，基于外键导航
                var bb = db.TB_WorkDtl.Where(p => p.CreateDate > new DateTime(2015, 7, 1) && p.TB_WorkMain.CreateDate > new DateTime(2015, 7, 1)).ToList();
                //...
                var test = (from c in db.TB_WorkMain
                            join d in db.TB_WorkDtl
                            //没一行c对应一组p
                            on c.WorkID equals d.ID into p
                            //如果没有下面这条语句，则p是一个集合，f为遍历对应的语句
                            from f in p.DefaultIfEmpty()
                            let m = "总数" + p.Count()
                            where c.CreateDate > new DateTime(2015, 7, 1)
                            select new { c, m, f }).ToList();
                dataGridView1.DataSource = test;

                //排列
                var test1 = from a1 in db.TB_WorkMain
                            orderby a1.CreateDate descending, a1.FinishedDate
                            select a1;
                var test2 = db.TB_WorkMain.OrderByDescending(p => p.CreateDate).ThenBy(p => p.CreateDate).OrderBy(p => p.CreateDate).ToList();

                //分组(与SQL不通，这个包括分组数据)
                var test3 = (from a2 in db.TB_WorkMain
                             group a2 by a2.PalletCode into b2
                             select b2).ToList();
                foreach (var item in test3)
                {
                    if (item.Key == "0117")
                    {
                        foreach (var item2 in item)
                        {
                            //...
                        }
                    }
                }
                var test4 = db.TB_WorkMain.GroupBy(p => p.PalletCode).ToList();
                //...

                char a4 = textBox1.Text[2];
                //空为false，非空为true
                var test5 = db.TB_WorkMain.Where(p => p.TB_WorkDtlForEachStation.Any()).ToList();
                var test6 = from a3 in db.TB_WorkMain
                            where a3.TB_WorkDtlForEachStation.Any()
                            select a3;
                //

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime begin = System.DateTime.Now;
            using (XinYaDBEntities db = new XinYaDBEntities())
            {
                //var b = db.TB_SystemLog.AsParallel().Select(p => new
                //{
                //    p.ID,
                //    p.Recorder,
                //    p.Source,
                //    p.SysLog,
                //    p.Time
                //}).ToList();
                var c = db.TB_WorkDtlForEachStation.ToList();
                var d = (from f in c
                         select Change(f)).ToList();
                //var b = db.TB_SystemLog.Include("TB_User").ToList();
                //foreach (var item in b)
                //{
                //    item.TB_User;
                //}
                //dataGridView1.DataSource = b;
                //var a = db.TB_WorkMain.Select(p => new
                //{
                //    p.WorkID,
                //    p.TB_User.UserName,
                //    p.CreateDate
                //});
                //dataGridView1.DataSource = a.ToList();
            }
            DateTime end = System.DateTime.Now;
            label1.Text = (end - begin).ToString();
        }
    }
}
