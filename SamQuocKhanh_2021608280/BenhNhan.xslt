<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:x ="http://tempuri.org/BenhNhan.xsd"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>

			<head>
				<style>
					body{
						text-align: center; display: flex;
						align-items: center;
					}
				</style>

			</head>
			<body padding ="0" margin="0">
				<table   width ="100%">
					<tr>
						<th width="200">BỆNH VIỆN ĐA KHOA</th>
						<th text-align="center">DANH SÁCH BỆNH NHÂN</th>
					</tr>
					
				</table>

				<br></br>
				<br></br>

				<xsl:for-each select="x:BVDK/x:Khoa" >
					<table   width ="100%">
						<tr>
							<th width="200">
							Khoa:	<xsl:value-of select="x:TenKhoa"/>
							</th>
							<th text-align="center">
							Phòng:	<xsl:value-of select="x:Phong"/>
							</th>
						</tr>
					</table>
					<br></br>


					<table   width ="100%" border="1" cellpadding="1">
						<tr>
							<th text-align="center">Mã Số BN</th>
							<th text-align="center">Họ tên</th>
							<th text-align="center">Ngày nhập viện</th>
							<th text-align="center">Số ngày điều trị</th>
							<th text-align="center">Số tiền phải trả</th>
						</tr>
						<xsl:for-each select="x:BenhNhan">
							<tr>
								<td>
									<xsl:value-of select="@MasoBN"/>
								</td>
								<td>
									<xsl:value-of select="x:HoTen"/>
								</td>
								<td>
									<xsl:value-of select="x:NgayNhapVien"/>
								</td>
								<td>
									<xsl:value-of select="x:NgayDieuTri"/>
								</td>
								<td>
									<xsl:number value="x:NgayDieuTri * 15000"/>
								</td>
								
							</tr>
						</xsl:for-each>
					</table>

					<br></br>
					
				</xsl:for-each>

			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
