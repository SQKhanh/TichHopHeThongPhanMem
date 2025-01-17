<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:x="http://tempuri.org/BenhNhan.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">

		<html>
			<style>
				.center {
					text-align: center;
				}
				.right {
					text-align: right;
				}
				table, th, td {
					border: 1px solid black;
					border-collapse: collapse;
				}
			</style>

			<body>
				<div style="display: inline;">BỆNH VIỆN ĐA KHOA</div>
				
				<div style="display: inline; margin-left: 100px; font-weight: bold;">DANH SÁCH BỆNH NHÂN</div>

				<xsl:for-each select="x:BVDK/x:Khoa">
					<div >
						Khoa: <xsl:value-of select="x:TenKhoa"/>
					</div>
					<div style="display: inline; margin-left: 50px">
						Phòng: <xsl:value-of select="x:Phong"/>
					</div>

					<table>
						<tr style="background-color:#abcdef">
							<th>STT</th>
							<th>Mã số BN</th>
							<th>Họ và tên</th>
							<th>Giới tính</th>
							<th>Ngày nhập viện</th>
							<th>Số ngày</th>
							<th>Số tiền phải trả</th>
						</tr>

						<xsl:for-each select="x:BenhNhan">
							<tr>
								<td class="center">
									<xsl:value-of select="position()"/>
								</td>
								<td class="center">
									<xsl:value-of select="@MasoBN"/>
								</td>
								<td class="center">
									<xsl:value-of select="x:HoTen"/>
								</td>
								<td class="center">
									<xsl:value-of select="x:GioiTinh"/>
								</td>
								<td class="center">
									<xsl:value-of select="x:NgayNhapVien"/>
								</td>
								<td class="center">
									<xsl:value-of select="x:NgayDieuTri"/>
								</td>
								<td class="center">
									<xsl:value-of select="x:NgayDieuTri * 15000"/>
								</td>
							</tr>		
						</xsl:for-each>
						
					</table>
					
				</xsl:for-each>
			</body>
			
		</html>
		
    </xsl:template>
</xsl:stylesheet>
