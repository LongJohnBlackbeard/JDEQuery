using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45715 - .
/// </summary>
public class F45715 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAST.
        /// </summary>
        public const string ABAST = "ABAST";

        /// <summary>
        /// ABAGTY.
        /// </summary>
        public const string ABAGTY = "ABAGTY";

        /// <summary>
        /// ABANS8.
        /// </summary>
        public const string ABANS8 = "ABANS8";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABITM.
        /// </summary>
        public const string ABITM = "ABITM";

        /// <summary>
        /// ABIGID.
        /// </summary>
        public const string ABIGID = "ABIGID";

        /// <summary>
        /// ABCGID.
        /// </summary>
        public const string ABCGID = "ABCGID";

        /// <summary>
        /// ABASAI.
        /// </summary>
        public const string ABASAI = "ABASAI";

        /// <summary>
        /// ABEFTJ.
        /// </summary>
        public const string ABEFTJ = "ABEFTJ";

        /// <summary>
        /// ABEXDJ.
        /// </summary>
        public const string ABEXDJ = "ABEXDJ";

        /// <summary>
        /// ABAGSP.
        /// </summary>
        public const string ABAGSP = "ABAGSP";

        /// <summary>
        /// ABAGIN.
        /// </summary>
        public const string ABAGIN = "ABAGIN";

        /// <summary>
        /// ABCATN.
        /// </summary>
        public const string ABCATN = "ABCATN";

        /// <summary>
        /// ABRPER.
        /// </summary>
        public const string ABRPER = "ABRPER";

        /// <summary>
        /// ABSCLM.
        /// </summary>
        public const string ABSCLM = "ABSCLM";

        /// <summary>
        /// ABCLMD.
        /// </summary>
        public const string ABCLMD = "ABCLMD";

        /// <summary>
        /// ABCCF3.
        /// </summary>
        public const string ABCCF3 = "ABCCF3";

        /// <summary>
        /// ABBDCS.
        /// </summary>
        public const string ABBDCS = "ABBDCS";

        /// <summary>
        /// ABBDCL.
        /// </summary>
        public const string ABBDCL = "ABBDCL";

        /// <summary>
        /// ABFRMN.
        /// </summary>
        public const string ABFRMN = "ABFRMN";

        /// <summary>
        /// ABFVMD.
        /// </summary>
        public const string ABFVMD = "ABFVMD";

        /// <summary>
        /// ABPUFR.
        /// </summary>
        public const string ABPUFR = "ABPUFR";

        /// <summary>
        /// ABMQYQ.
        /// </summary>
        public const string ABMQYQ = "ABMQYQ";

        /// <summary>
        /// ABMAQY.
        /// </summary>
        public const string ABMAQY = "ABMAQY";

        /// <summary>
        /// ABQYOA.
        /// </summary>
        public const string ABQYOA = "ABQYOA";

        /// <summary>
        /// ABQYAP.
        /// </summary>
        public const string ABQYAP = "ABQYAP";

        /// <summary>
        /// ABQYCL.
        /// </summary>
        public const string ABQYCL = "ABQYCL";

        /// <summary>
        /// ABUOM.
        /// </summary>
        public const string ABUOM = "ABUOM";

        /// <summary>
        /// ABBC01.
        /// </summary>
        public const string ABBC01 = "ABBC01";

        /// <summary>
        /// ABBC02.
        /// </summary>
        public const string ABBC02 = "ABBC02";

        /// <summary>
        /// ABBC03.
        /// </summary>
        public const string ABBC03 = "ABBC03";

        /// <summary>
        /// ABBC04.
        /// </summary>
        public const string ABBC04 = "ABBC04";

        /// <summary>
        /// ABBC05.
        /// </summary>
        public const string ABBC05 = "ABBC05";

        /// <summary>
        /// ABURCD.
        /// </summary>
        public const string ABURCD = "ABURCD";

        /// <summary>
        /// ABURDT.
        /// </summary>
        public const string ABURDT = "ABURDT";

        /// <summary>
        /// ABURAT.
        /// </summary>
        public const string ABURAT = "ABURAT";

        /// <summary>
        /// ABURAB.
        /// </summary>
        public const string ABURAB = "ABURAB";

        /// <summary>
        /// ABURRF.
        /// </summary>
        public const string ABURRF = "ABURRF";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABTDAY.
        /// </summary>
        public const string ABTDAY = "ABTDAY";

        /// <summary>
        /// ABAGNB.
        /// </summary>
        public const string ABAGNB = "ABAGNB";
    }

    /// <inheritdoc />
    public override string TableName => "F45715";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAST", "ABAST", JdeDataType.String, 16, true, true),
        new JdeField("ABAGTY", "ABAGTY", JdeDataType.String, 4, true, true),
        new JdeField("ABANS8", "ABANS8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24, true, true),
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABITM", "ABITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ABIGID", "ABIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABCGID", "ABCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABASAI", "ABASAI", JdeDataType.String, 2),
        new JdeField("ABEFTJ", "ABEFTJ", JdeDataType.Numeric),
        new JdeField("ABEXDJ", "ABEXDJ", JdeDataType.Numeric),
        new JdeField("ABAGSP", "ABAGSP", JdeDataType.String, 16),
        new JdeField("ABAGIN", "ABAGIN", JdeDataType.Numeric),
        new JdeField("ABCATN", "ABCATN", JdeDataType.String, 16),
        new JdeField("ABRPER", "ABRPER", JdeDataType.Numeric),
        new JdeField("ABSCLM", "ABSCLM", JdeDataType.Numeric),
        new JdeField("ABCLMD", "ABCLMD", JdeDataType.String, 2),
        new JdeField("ABCCF3", "ABCCF3", JdeDataType.String, 6),
        new JdeField("ABBDCS", "ABBDCS", JdeDataType.Numeric),
        new JdeField("ABBDCL", "ABBDCL", JdeDataType.String, 2),
        new JdeField("ABFRMN", "ABFRMN", JdeDataType.String, 20),
        new JdeField("ABFVMD", "ABFVMD", JdeDataType.String, 2),
        new JdeField("ABPUFR", "ABPUFR", JdeDataType.String, 2),
        new JdeField("ABMQYQ", "ABMQYQ", JdeDataType.Numeric),
        new JdeField("ABMAQY", "ABMAQY", JdeDataType.Numeric),
        new JdeField("ABQYOA", "ABQYOA", JdeDataType.Numeric),
        new JdeField("ABQYAP", "ABQYAP", JdeDataType.Numeric),
        new JdeField("ABQYCL", "ABQYCL", JdeDataType.Numeric),
        new JdeField("ABUOM", "ABUOM", JdeDataType.String, 4),
        new JdeField("ABBC01", "ABBC01", JdeDataType.String, 6),
        new JdeField("ABBC02", "ABBC02", JdeDataType.String, 6),
        new JdeField("ABBC03", "ABBC03", JdeDataType.String, 6),
        new JdeField("ABBC04", "ABBC04", JdeDataType.String, 6),
        new JdeField("ABBC05", "ABBC05", JdeDataType.String, 6),
        new JdeField("ABURCD", "ABURCD", JdeDataType.String, 4),
        new JdeField("ABURDT", "ABURDT", JdeDataType.Numeric),
        new JdeField("ABURAT", "ABURAT", JdeDataType.Numeric),
        new JdeField("ABURAB", "ABURAB", JdeDataType.Numeric),
        new JdeField("ABURRF", "ABURRF", JdeDataType.String, 30),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABTDAY", "ABTDAY", JdeDataType.Numeric),
        new JdeField("ABAGNB", "ABAGNB", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45715_0", "Primary Key on ABAST, ABAGTY, ABANS8, ABMCU, ABAN8, ABITM, ABIGID, ABCGID", new[] { "ABAST", "ABAGTY", "ABANS8", "ABMCU", "ABAN8", "ABITM", "ABIGID", "ABCGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F45715_2", "Index on ABAST, ABAGTY", new[] { "ABAST", "ABAGTY" })
    };
}
