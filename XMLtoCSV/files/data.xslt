﻿<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" version="1.0" encoding="UTF-8"/>
  <xsl:template match="/">
    <xsl:for-each select="//Point">
      <xsl:value-of select="X"/>,<xsl:value-of select="Y"/>
      <xsl:text>&#xD;&#xA;</xsl:text>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>