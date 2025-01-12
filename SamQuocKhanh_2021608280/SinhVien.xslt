<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:x="http://tempuri.org/SinhVien.xsd"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table border="1" cellpadding="1">
					
					<tr>
						<th>STT</th>
						<th>Mã SV</th>
						<th>Tên SV</th>
						<th>Giới Tính</th>
						<th>Ngày Sinh</th>
						<th>Mã Lớp</th>
					</tr>
					<xsl:for-each select="x:DS/x:SinhVien">
						<xsl:sort select="x:TenSV"  order="ascending"/>
						<tr>
							<td>
								<xsl:value-of select="position()"/>
							</td>
							<td>
								<xsl:value-of select="x:MaSV"/>
							</td>
							<td>
								<xsl:value-of select="x:TenSV"/>
							</td>
							<td>
								<xsl:value-of select="x:GioiTinh"/>
							</td>
							<td>
								<xsl:value-of select="x:NgaySinh"/>
							</td>
							<td>
								<xsl:value-of select="x:MaLop"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
