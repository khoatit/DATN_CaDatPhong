using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class CaDatPhong
	{
			public int Id { get; set; }  // ID cho mỗi ca đặt phòng
			public TimeSpan GioCheckIn { get; set; }  // Giờ check-in
			public TimeSpan GioCheckOut { get; set; }  // Giờ check-out
			public string GhiChu { get; set; }  // Ghi chú
	}
}
