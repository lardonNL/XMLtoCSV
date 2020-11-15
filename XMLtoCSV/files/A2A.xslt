<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" 
  xmlns="http://Mindbus.nl/RecordCollectionA2A"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:a2a="http://Mindbus.nl/A2A"
  >
  
  <!--<xsl:output method="text" version="1.0" encoding="UTF-8"/>-->
  <xsl:template match="/">
     test
    <xsl:for-each select="A2ACollection/a2a:A2A">
      test2
      <xsl:value-of select="a2a:Person/a2a:PersonName/a2a:PersonNameFirstName"/>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
