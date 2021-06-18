using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTheComic.DAL;
using SaveTheComic.GUI;

namespace SaveTheComic.BUS
{
    class BUSTruyen
    {
        public static void themTruyen(Truyen t)
        {
            if (DBGet<Truyen>.getData("tenTruyen", t.tenTruyen) != null)
            {
                //Alert("Truyện đã tồn tại", AlertForm.enmType.Info);
                AlertForm.Alert("Truyện đã tồn tại", AlertForm.enmType.Info);
                return;
            }

            DBTruyen.addData(t);
            //Alert("Đã thêm " + t.tenTruyen, AlertForm.enmType.Success);
            AlertForm.Alert("Đã thêm " + t.tenTruyen, AlertForm.enmType.Success);
        }

        public static void xoaTruyen(Truyen t)
        {
            if (DBTruyen.removeData(t))
                Alert("Đã xóa " + t.tenTruyen, AlertForm.enmType.Error);
            else
                Alert("Không thể xóa truyện này", AlertForm.enmType.Error);
        }

        public static void capNhatTruyen(Truyen t)
        {
            DBTruyen.updateData(t);
            Alert("Đã cập nhật lại " + t.tenTruyen, AlertForm.enmType.Warning);
        }

        public static void Alert(string msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
        }
    }
}
