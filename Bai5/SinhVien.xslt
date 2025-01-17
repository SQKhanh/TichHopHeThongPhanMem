<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:x="http://tempuri.org/SinhVien.xsd"			
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>STT</th>
						<th>Mã SV</th>
						<th>Họ và tên</th>
						<th>Giới tính</th>
						<th>Ngày sinh</th>
						<th>Mã lớp</th>
					</tr>
					<xsl:for-each select="x:dssv/x:sinhvien">
						<xsl:sort select="x:tensv"/>
						<tr>
							<td>
								<xsl:value-of select="position()"/>
							</td>
							<td>
								<xsl:value-of select="x:masv"/>
							</td>
							<td>
								<xsl:value-of select="x:tensv"/>
							</td>
							<td>
								<xsl:value-of select="x:gioitinh"/>
							</td>
							<td>
								<xsl:value-of select="x:ngaysinh"/>
							</td>
							<td>
								<xsl:value-of select="x:malop"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
