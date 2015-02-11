using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTS
{
    public partial class frm_History : Form
    {
        public frm_History()
        {
            InitializeComponent();
        }

        private void frm_History_Load(object sender, EventArgs e)
        {
            //将更新文本写于此处，以实现更新历史倒排
            tex_History.AppendText("\r\n2014-02-23 修改功能\r\n 将数据库的连接字符串改为由C改写的DLL实现");
            tex_History.AppendText("\r\n2014-01-04 增加功能\r\n 包装打印功能");
            tex_History.AppendText("\r\n2013-11-19 增加功能\r\n 条码打印功能");
            tex_History.AppendText("\r\n2013-11-14 增加功能\r\n 导出条码产生记录时可以按时间来导出");
            tex_History.AppendText("\r\n2013-10-09 增加功能\r\n 烧机显示按烧机室分开显示");
            tex_History.AppendText("\r\n2013-09-27 增加功能\r\n 增加两处导出excel功能");
            tex_History.AppendText("\r\n2013-09-11 增加功能\r\n 在每个站点显示当前站点的每个小时的产量");
            tex_History.AppendText("\r\n2013-08-20 增加功能\r\n 控制权限，当不是管理员时，基础资料菜单不可用");
            tex_History.AppendText("\r\n2013-08-20 增加功能\r\n 在条码录入时与维修时，可以方便的选择编码");
            tex_History.AppendText("\r\n2013-08-08 更改逻辑\r\n 部分站点可以在PASS以后还可以扫FAIL，这个逻辑是有问题的，但也实现");
            tex_History.AppendText("\r\n2013-08-06 修改逻辑 \r\n 只有部分站才需要在录入条码之前才需要选择产品型号");
            tex_History.AppendText("\r\n2013-04-24 增加功能 \r\n 综合查询中，增加烧机的查询功能,增加显示页数功能");
            tex_History.AppendText("\r\n2013-04-19 增加判断 \r\n 在录入条码之前需要选择产品型号，判断当前输入的条码是否与所选择的产品型一致，如不一致则报错");
            tex_History.AppendText("\r\n2013-03-29 修正逻辑 \r\n 双击烧机完成的行时，页面刷新停止，需停留在当页面，页面重新刷新");
            tex_History.AppendText("\r\n2013-02-03 增加功能 \r\n 双击烧机完成的行时，页面刷新停止，重开页面时，页面重新刷新");
            tex_History.AppendText("\r\n2013-01-15 增加功能 \r\n 将显示板程序纳入到MTS中管理");
            tex_History.AppendText("\r\n2013-01-08 增加功能 \r\n 在成品绑定界面，加入一个明显提示，以显示是否保存成功");
            tex_History.AppendText("\r\n2012-12-25 增加功能 \r\n 在条码录入界面，加入一个明显提示，以显示是否保存成功");
            tex_History.AppendText("\r\n2012-12-19 增加功能 \r\n 增加一个综合查询，通过此界面可以查询该条码所有的历史记录");
            tex_History.AppendText("\r\n2012-12-14 改进功能 \r\n 更改写数据库为存储过程，并加入事务类型，如果写不成功，数据就会回滚");
            tex_History.AppendText("\r\n2012-12-13 增加功能 \r\n 在组装站增加了许多说明，以说明为什么成品与组件不能绑定，并绑定完成后，组件框不可用，以显示组装完毕");
            tex_History.AppendText("\r\n2012-12-12 更新逻辑 \r\n 当组件绑定时不再查询组装顺序表，而改为查询BOM表中的排列顺序，简化工艺人员工作");
            tex_History.AppendText("\r\n2012-12-04 更新逻辑 \r\n 当组件绑定时不再查询完工记录，改为查询该组件是否经过了最后一站并且PASS");
            tex_History.AppendText("\r\n2012-12-04 增加功能 \r\n 需要用户登录才能使用本系统");
            tex_History.AppendText("\r\n2012-11-20 增强功能 \r\n 在导出到EXCEL中加入产品型号的数据");
            tex_History.AppendText("\r\n2012-11-19 增加功能 \r\n 增加了按日期和站点的过滤后导出到EXCEL功能");
            tex_History.AppendText("2012-11-02 更新逻辑 \r\n 子件被绑定过以后，不可以再绑定到别的产品上 ");
            tex_History.Select(0, 0);

        }
    }
}
