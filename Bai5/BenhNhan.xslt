<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:x="http://tempuri.org/BenhNhan.xsd"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
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
				BỆNH VIỆN ĐA KHOA
				<div style="margin-left: 180px; font-size: 20px; font-weight: bold">
					DANH SÁCH BỆNH NHÂN
				</div>
				<xsl:for-each select="x:bvdk/x:khoa">
					<div style="display: inline">
						Khoa: <xsl:value-of select="x:tenkhoa"/>
					</div>
					<div style="display: inline; margin-left: 50px">
						Phòng: <xsl:value-of select="x:phong"/>
					</div>
					<table>
						<tr style="background-color:#9acd32">
							<th>STT</th>
							<th>Mã số BN</th>
							<th>Họ và tên</th>
							<th>Giới tính</th>
							<th>Ngày nhập viện</th>
							<th>Số ngày</th>
							<th>Số tiền phải trả</th>
						</tr>
						<xsl:for-each select="x:benhnhan">					
						<tr>
							<td class="center">
								<xsl:value-of select="position()"/>
							</td>
							<td class="center">
								<xsl:value-of select="@masobn"/>
							</td>
							<td>
								<xsl:value-of select="x:hoten"/>
							</td>
							<td>
								<xsl:value-of select="x:gioitinh"/>
							</td>
							<td class="center">
								<xsl:value-of select="x:ngaynhapvien"/>
							</td>
							<td class="right">
								<xsl:value-of select="x:ngaydieutri"/>
							</td>
							<td class="right">
								<xsl:value-of select="15000*x:ngaydieutri"/>
							</td>
						</tr>
						</xsl:for-each>
					</table>
					<p></p>
				</xsl:for-each>				
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
