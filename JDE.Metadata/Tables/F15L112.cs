using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L112 - .
/// </summary>
public class F15L112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADASSD.
        /// </summary>
        public const string ADASSD = "ADASSD";

        /// <summary>
        /// ADRVNB.
        /// </summary>
        public const string ADRVNB = "ADRVNB";

        /// <summary>
        /// ADLNID.
        /// </summary>
        public const string ADLNID = "ADLNID";

        /// <summary>
        /// ADDS50.
        /// </summary>
        public const string ADDS50 = "ADDS50";

        /// <summary>
        /// ADASTP.
        /// </summary>
        public const string ADASTP = "ADASTP";

        /// <summary>
        /// ADGLC.
        /// </summary>
        public const string ADGLC = "ADGLC";

        /// <summary>
        /// ADOBJ.
        /// </summary>
        public const string ADOBJ = "ADOBJ";

        /// <summary>
        /// ADGA01.
        /// </summary>
        public const string ADGA01 = "ADGA01";

        /// <summary>
        /// ADGA02.
        /// </summary>
        public const string ADGA02 = "ADGA02";

        /// <summary>
        /// ADLAMT.
        /// </summary>
        public const string ADLAMT = "ADLAMT";

        /// <summary>
        /// ADCALM.
        /// </summary>
        public const string ADCALM = "ADCALM";

        /// <summary>
        /// ADGRPA.
        /// </summary>
        public const string ADGRPA = "ADGRPA";

        /// <summary>
        /// ADRBC01.
        /// </summary>
        public const string ADRBC01 = "ADRBC01";

        /// <summary>
        /// ADRBC02.
        /// </summary>
        public const string ADRBC02 = "ADRBC02";

        /// <summary>
        /// ADRBC03.
        /// </summary>
        public const string ADRBC03 = "ADRBC03";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADTORG.
        /// </summary>
        public const string ADTORG = "ADTORG";

        /// <summary>
        /// ADENTJ.
        /// </summary>
        public const string ADENTJ = "ADENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24, true, true),
        new JdeField("ADASSD", "ADASSD", JdeDataType.String, 20, true, true),
        new JdeField("ADRVNB", "ADRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("ADLNID", "ADLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADDS50", "ADDS50", JdeDataType.String, 100),
        new JdeField("ADASTP", "ADASTP", JdeDataType.String, 4),
        new JdeField("ADGLC", "ADGLC", JdeDataType.String, 8),
        new JdeField("ADOBJ", "ADOBJ", JdeDataType.String, 12),
        new JdeField("ADGA01", "ADGA01", JdeDataType.Numeric),
        new JdeField("ADGA02", "ADGA02", JdeDataType.Numeric),
        new JdeField("ADLAMT", "ADLAMT", JdeDataType.String, 4),
        new JdeField("ADCALM", "ADCALM", JdeDataType.String, 2),
        new JdeField("ADGRPA", "ADGRPA", JdeDataType.String, 20),
        new JdeField("ADRBC01", "ADRBC01", JdeDataType.String, 8),
        new JdeField("ADRBC02", "ADRBC02", JdeDataType.String, 8),
        new JdeField("ADRBC03", "ADRBC03", JdeDataType.String, 8),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADTORG", "ADTORG", JdeDataType.String, 20),
        new JdeField("ADENTJ", "ADENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L112_0", "Primary Key on ADMCU, ADASSD, ADRVNB, ADLNID", new[] { "ADMCU", "ADASSD", "ADRVNB", "ADLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
