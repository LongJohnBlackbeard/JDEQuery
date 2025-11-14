using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08001 - .
/// </summary>
public class F08001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JMJGRP.
        /// </summary>
        public const string JMJGRP = "JMJGRP";

        /// <summary>
        /// JMJBCD.
        /// </summary>
        public const string JMJBCD = "JMJBCD";

        /// <summary>
        /// JMJBST.
        /// </summary>
        public const string JMJBST = "JMJBST";

        /// <summary>
        /// JMDL01.
        /// </summary>
        public const string JMDL01 = "JMDL01";

        /// <summary>
        /// JMSALY.
        /// </summary>
        public const string JMSALY = "JMSALY";

        /// <summary>
        /// JMPGRD.
        /// </summary>
        public const string JMPGRD = "JMPGRD";

        /// <summary>
        /// JMPFRQ.
        /// </summary>
        public const string JMPFRQ = "JMPFRQ";

        /// <summary>
        /// JMEEOJ.
        /// </summary>
        public const string JMEEOJ = "JMEEOJ";

        /// <summary>
        /// JMWCMP.
        /// </summary>
        public const string JMWCMP = "JMWCMP";

        /// <summary>
        /// JMWET.
        /// </summary>
        public const string JMWET = "JMWET";

        /// <summary>
        /// JMFLSA.
        /// </summary>
        public const string JMFLSA = "JMFLSA";

        /// <summary>
        /// JMDIVC.
        /// </summary>
        public const string JMDIVC = "JMDIVC";

        /// <summary>
        /// JMUN.
        /// </summary>
        public const string JMUN = "JMUN";

        /// <summary>
        /// JMEMET.
        /// </summary>
        public const string JMEMET = "JMEMET";

        /// <summary>
        /// JMEVD.
        /// </summary>
        public const string JMEVD = "JMEVD";

        /// <summary>
        /// JMEPNT.
        /// </summary>
        public const string JMEPNT = "JMEPNT";

        /// <summary>
        /// JMD001.
        /// </summary>
        public const string JMD001 = "JMD001";

        /// <summary>
        /// JMD002.
        /// </summary>
        public const string JMD002 = "JMD002";

        /// <summary>
        /// JMD003.
        /// </summary>
        public const string JMD003 = "JMD003";

        /// <summary>
        /// JMD004.
        /// </summary>
        public const string JMD004 = "JMD004";

        /// <summary>
        /// JMD005.
        /// </summary>
        public const string JMD005 = "JMD005";

        /// <summary>
        /// JMD006.
        /// </summary>
        public const string JMD006 = "JMD006";

        /// <summary>
        /// JMD007.
        /// </summary>
        public const string JMD007 = "JMD007";

        /// <summary>
        /// JMD008.
        /// </summary>
        public const string JMD008 = "JMD008";

        /// <summary>
        /// JMD009.
        /// </summary>
        public const string JMD009 = "JMD009";

        /// <summary>
        /// JMD010.
        /// </summary>
        public const string JMD010 = "JMD010";

        /// <summary>
        /// JMPT01.
        /// </summary>
        public const string JMPT01 = "JMPT01";

        /// <summary>
        /// JMPT02.
        /// </summary>
        public const string JMPT02 = "JMPT02";

        /// <summary>
        /// JMPT03.
        /// </summary>
        public const string JMPT03 = "JMPT03";

        /// <summary>
        /// JMPT04.
        /// </summary>
        public const string JMPT04 = "JMPT04";

        /// <summary>
        /// JMPT05.
        /// </summary>
        public const string JMPT05 = "JMPT05";

        /// <summary>
        /// JMPT06.
        /// </summary>
        public const string JMPT06 = "JMPT06";

        /// <summary>
        /// JMPT07.
        /// </summary>
        public const string JMPT07 = "JMPT07";

        /// <summary>
        /// JMPT08.
        /// </summary>
        public const string JMPT08 = "JMPT08";

        /// <summary>
        /// JMPT09.
        /// </summary>
        public const string JMPT09 = "JMPT09";

        /// <summary>
        /// JMPT10.
        /// </summary>
        public const string JMPT10 = "JMPT10";

        /// <summary>
        /// JMP001.
        /// </summary>
        public const string JMP001 = "JMP001";

        /// <summary>
        /// JMP002.
        /// </summary>
        public const string JMP002 = "JMP002";

        /// <summary>
        /// JMP003.
        /// </summary>
        public const string JMP003 = "JMP003";

        /// <summary>
        /// JMP004.
        /// </summary>
        public const string JMP004 = "JMP004";

        /// <summary>
        /// JMP005.
        /// </summary>
        public const string JMP005 = "JMP005";

        /// <summary>
        /// JMP006.
        /// </summary>
        public const string JMP006 = "JMP006";

        /// <summary>
        /// JMP007.
        /// </summary>
        public const string JMP007 = "JMP007";

        /// <summary>
        /// JMP008.
        /// </summary>
        public const string JMP008 = "JMP008";

        /// <summary>
        /// JMP009.
        /// </summary>
        public const string JMP009 = "JMP009";

        /// <summary>
        /// JMP010.
        /// </summary>
        public const string JMP010 = "JMP010";

        /// <summary>
        /// JMFE01.
        /// </summary>
        public const string JMFE01 = "JMFE01";

        /// <summary>
        /// JMFE02.
        /// </summary>
        public const string JMFE02 = "JMFE02";

        /// <summary>
        /// JMFE03.
        /// </summary>
        public const string JMFE03 = "JMFE03";

        /// <summary>
        /// JMFE04.
        /// </summary>
        public const string JMFE04 = "JMFE04";

        /// <summary>
        /// JMFE05.
        /// </summary>
        public const string JMFE05 = "JMFE05";

        /// <summary>
        /// JMFE06.
        /// </summary>
        public const string JMFE06 = "JMFE06";

        /// <summary>
        /// JMFE07.
        /// </summary>
        public const string JMFE07 = "JMFE07";

        /// <summary>
        /// JMFE08.
        /// </summary>
        public const string JMFE08 = "JMFE08";

        /// <summary>
        /// JMFE09.
        /// </summary>
        public const string JMFE09 = "JMFE09";

        /// <summary>
        /// JMFE10.
        /// </summary>
        public const string JMFE10 = "JMFE10";

        /// <summary>
        /// JMFW01.
        /// </summary>
        public const string JMFW01 = "JMFW01";

        /// <summary>
        /// JMFW02.
        /// </summary>
        public const string JMFW02 = "JMFW02";

        /// <summary>
        /// JMFW03.
        /// </summary>
        public const string JMFW03 = "JMFW03";

        /// <summary>
        /// JMFW04.
        /// </summary>
        public const string JMFW04 = "JMFW04";

        /// <summary>
        /// JMFW05.
        /// </summary>
        public const string JMFW05 = "JMFW05";

        /// <summary>
        /// JMFW06.
        /// </summary>
        public const string JMFW06 = "JMFW06";

        /// <summary>
        /// JMFW07.
        /// </summary>
        public const string JMFW07 = "JMFW07";

        /// <summary>
        /// JMFW08.
        /// </summary>
        public const string JMFW08 = "JMFW08";

        /// <summary>
        /// JMFW09.
        /// </summary>
        public const string JMFW09 = "JMFW09";

        /// <summary>
        /// JMFW10.
        /// </summary>
        public const string JMFW10 = "JMFW10";

        /// <summary>
        /// JMJSTA.
        /// </summary>
        public const string JMJSTA = "JMJSTA";

        /// <summary>
        /// JMEFTB.
        /// </summary>
        public const string JMEFTB = "JMEFTB";

        /// <summary>
        /// JMEFTE.
        /// </summary>
        public const string JMEFTE = "JMEFTE";

        /// <summary>
        /// JMUSER.
        /// </summary>
        public const string JMUSER = "JMUSER";

        /// <summary>
        /// JMPID.
        /// </summary>
        public const string JMPID = "JMPID";

        /// <summary>
        /// JMJOBN.
        /// </summary>
        public const string JMJOBN = "JMJOBN";

        /// <summary>
        /// JMUPMJ.
        /// </summary>
        public const string JMUPMJ = "JMUPMJ";

        /// <summary>
        /// JMPGRS.
        /// </summary>
        public const string JMPGRS = "JMPGRS";

        /// <summary>
        /// JMCENC.
        /// </summary>
        public const string JMCENC = "JMCENC";

        /// <summary>
        /// JMSTCR.
        /// </summary>
        public const string JMSTCR = "JMSTCR";
    }

    /// <inheritdoc />
    public override string TableName => "F08001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JMJGRP", "JMJGRP", JdeDataType.String, 12),
        new JdeField("JMJBCD", "JMJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JMJBST", "JMJBST", JdeDataType.String, 8, true, true),
        new JdeField("JMDL01", "JMDL01", JdeDataType.String, 60),
        new JdeField("JMSALY", "JMSALY", JdeDataType.String, 2),
        new JdeField("JMPGRD", "JMPGRD", JdeDataType.String, 12),
        new JdeField("JMPFRQ", "JMPFRQ", JdeDataType.String, 2),
        new JdeField("JMEEOJ", "JMEEOJ", JdeDataType.String, 6),
        new JdeField("JMWCMP", "JMWCMP", JdeDataType.String, 8),
        new JdeField("JMWET", "JMWET", JdeDataType.String, 2),
        new JdeField("JMFLSA", "JMFLSA", JdeDataType.String, 2),
        new JdeField("JMDIVC", "JMDIVC", JdeDataType.String, 12),
        new JdeField("JMUN", "JMUN", JdeDataType.String, 12),
        new JdeField("JMEMET", "JMEMET", JdeDataType.String, 8),
        new JdeField("JMEVD", "JMEVD", JdeDataType.Numeric),
        new JdeField("JMEPNT", "JMEPNT", JdeDataType.Numeric),
        new JdeField("JMD001", "JMD001", JdeDataType.Numeric),
        new JdeField("JMD002", "JMD002", JdeDataType.Numeric),
        new JdeField("JMD003", "JMD003", JdeDataType.Numeric),
        new JdeField("JMD004", "JMD004", JdeDataType.Numeric),
        new JdeField("JMD005", "JMD005", JdeDataType.Numeric),
        new JdeField("JMD006", "JMD006", JdeDataType.Numeric),
        new JdeField("JMD007", "JMD007", JdeDataType.Numeric),
        new JdeField("JMD008", "JMD008", JdeDataType.Numeric),
        new JdeField("JMD009", "JMD009", JdeDataType.Numeric),
        new JdeField("JMD010", "JMD010", JdeDataType.Numeric),
        new JdeField("JMPT01", "JMPT01", JdeDataType.Numeric),
        new JdeField("JMPT02", "JMPT02", JdeDataType.Numeric),
        new JdeField("JMPT03", "JMPT03", JdeDataType.Numeric),
        new JdeField("JMPT04", "JMPT04", JdeDataType.Numeric),
        new JdeField("JMPT05", "JMPT05", JdeDataType.Numeric),
        new JdeField("JMPT06", "JMPT06", JdeDataType.Numeric),
        new JdeField("JMPT07", "JMPT07", JdeDataType.Numeric),
        new JdeField("JMPT08", "JMPT08", JdeDataType.Numeric),
        new JdeField("JMPT09", "JMPT09", JdeDataType.Numeric),
        new JdeField("JMPT10", "JMPT10", JdeDataType.Numeric),
        new JdeField("JMP001", "JMP001", JdeDataType.String, 6),
        new JdeField("JMP002", "JMP002", JdeDataType.String, 6),
        new JdeField("JMP003", "JMP003", JdeDataType.String, 6),
        new JdeField("JMP004", "JMP004", JdeDataType.String, 6),
        new JdeField("JMP005", "JMP005", JdeDataType.String, 6),
        new JdeField("JMP006", "JMP006", JdeDataType.String, 6),
        new JdeField("JMP007", "JMP007", JdeDataType.String, 6),
        new JdeField("JMP008", "JMP008", JdeDataType.String, 6),
        new JdeField("JMP009", "JMP009", JdeDataType.String, 6),
        new JdeField("JMP010", "JMP010", JdeDataType.String, 6),
        new JdeField("JMFE01", "JMFE01", JdeDataType.String, 20),
        new JdeField("JMFE02", "JMFE02", JdeDataType.String, 20),
        new JdeField("JMFE03", "JMFE03", JdeDataType.String, 20),
        new JdeField("JMFE04", "JMFE04", JdeDataType.String, 20),
        new JdeField("JMFE05", "JMFE05", JdeDataType.String, 20),
        new JdeField("JMFE06", "JMFE06", JdeDataType.String, 20),
        new JdeField("JMFE07", "JMFE07", JdeDataType.String, 20),
        new JdeField("JMFE08", "JMFE08", JdeDataType.String, 20),
        new JdeField("JMFE09", "JMFE09", JdeDataType.String, 20),
        new JdeField("JMFE10", "JMFE10", JdeDataType.String, 20),
        new JdeField("JMFW01", "JMFW01", JdeDataType.Numeric),
        new JdeField("JMFW02", "JMFW02", JdeDataType.Numeric),
        new JdeField("JMFW03", "JMFW03", JdeDataType.Numeric),
        new JdeField("JMFW04", "JMFW04", JdeDataType.Numeric),
        new JdeField("JMFW05", "JMFW05", JdeDataType.Numeric),
        new JdeField("JMFW06", "JMFW06", JdeDataType.Numeric),
        new JdeField("JMFW07", "JMFW07", JdeDataType.Numeric),
        new JdeField("JMFW08", "JMFW08", JdeDataType.Numeric),
        new JdeField("JMFW09", "JMFW09", JdeDataType.Numeric),
        new JdeField("JMFW10", "JMFW10", JdeDataType.Numeric),
        new JdeField("JMJSTA", "JMJSTA", JdeDataType.String, 6),
        new JdeField("JMEFTB", "JMEFTB", JdeDataType.Numeric),
        new JdeField("JMEFTE", "JMEFTE", JdeDataType.Numeric),
        new JdeField("JMUSER", "JMUSER", JdeDataType.String, 20),
        new JdeField("JMPID", "JMPID", JdeDataType.String, 20),
        new JdeField("JMJOBN", "JMJOBN", JdeDataType.String, 20),
        new JdeField("JMUPMJ", "JMUPMJ", JdeDataType.Numeric),
        new JdeField("JMPGRS", "JMPGRS", JdeDataType.String, 8),
        new JdeField("JMCENC", "JMCENC", JdeDataType.String, 8),
        new JdeField("JMSTCR", "JMSTCR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08001_0", "Primary Key on JMJBCD, JMJBST", new[] { "JMJBCD", "JMJBST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08001_10", "Index on JMEMET, SYS_NC00083$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00083$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_11", "Index on JMEMET, SYS_NC00084$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00084$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_12", "Index on JMEMET, SYS_NC00085$, SYS_NC00086$, JMJBST", new[] { "JMEMET", "SYS_NC00085$", "SYS_NC00086$", "JMJBST" }),
        new JdeIndex("F08001_2", "Index on JMEMET, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_3", "Index on JMEMET, SYS_NC00087$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00087$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_4", "Index on JMEMET, SYS_NC00088$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00088$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_5", "Index on JMEMET, SYS_NC00077$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00077$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_6", "Index on JMEMET, SYS_NC00079$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00079$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_7", "Index on JMEMET, SYS_NC00080$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00080$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_8", "Index on JMEMET, SYS_NC00081$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00081$", "JMJBCD", "SYS_NC00078$" }),
        new JdeIndex("F08001_9", "Index on JMEMET, SYS_NC00082$, JMJBCD, SYS_NC00078$", new[] { "JMEMET", "SYS_NC00082$", "JMJBCD", "SYS_NC00078$" })
    };
}
