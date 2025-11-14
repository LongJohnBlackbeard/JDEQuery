using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B97 - .
/// </summary>
public class F31B97 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HRUKID.
        /// </summary>
        public const string HRUKID = "HRUKID";

        /// <summary>
        /// HRWOPID.
        /// </summary>
        public const string HRWOPID = "HRWOPID";

        /// <summary>
        /// HRWGID.
        /// </summary>
        public const string HRWGID = "HRWGID";

        /// <summary>
        /// HRSFNB.
        /// </summary>
        public const string HRSFNB = "HRSFNB";

        /// <summary>
        /// HRWACTIME.
        /// </summary>
        public const string HRWACTIME = "HRWACTIME";

        /// <summary>
        /// HRWTUOM.
        /// </summary>
        public const string HRWTUOM = "HRWTUOM";

        /// <summary>
        /// HRURAB.
        /// </summary>
        public const string HRURAB = "HRURAB";

        /// <summary>
        /// HRURAT.
        /// </summary>
        public const string HRURAT = "HRURAT";

        /// <summary>
        /// HRURCD.
        /// </summary>
        public const string HRURCD = "HRURCD";

        /// <summary>
        /// HRURDT.
        /// </summary>
        public const string HRURDT = "HRURDT";

        /// <summary>
        /// HRURRF.
        /// </summary>
        public const string HRURRF = "HRURRF";

        /// <summary>
        /// HRWAB.
        /// </summary>
        public const string HRWAB = "HRWAB";

        /// <summary>
        /// HRWNUM.
        /// </summary>
        public const string HRWNUM = "HRWNUM";

        /// <summary>
        /// HRWCD.
        /// </summary>
        public const string HRWCD = "HRWCD";

        /// <summary>
        /// HRWMDT.
        /// </summary>
        public const string HRWMDT = "HRWMDT";

        /// <summary>
        /// HRWRF.
        /// </summary>
        public const string HRWRF = "HRWRF";

        /// <summary>
        /// HRUSER.
        /// </summary>
        public const string HRUSER = "HRUSER";

        /// <summary>
        /// HRUPMJ.
        /// </summary>
        public const string HRUPMJ = "HRUPMJ";

        /// <summary>
        /// HRUPMT.
        /// </summary>
        public const string HRUPMT = "HRUPMT";

        /// <summary>
        /// HRJOBN.
        /// </summary>
        public const string HRJOBN = "HRJOBN";

        /// <summary>
        /// HRMKEY.
        /// </summary>
        public const string HRMKEY = "HRMKEY";

        /// <summary>
        /// HRPID.
        /// </summary>
        public const string HRPID = "HRPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B97";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HRUKID", "HRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("HRWOPID", "HRWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("HRWGID", "HRWGID", JdeDataType.String, 16),
        new JdeField("HRSFNB", "HRSFNB", JdeDataType.Numeric),
        new JdeField("HRWACTIME", "HRWACTIME", JdeDataType.Numeric),
        new JdeField("HRWTUOM", "HRWTUOM", JdeDataType.String, 4),
        new JdeField("HRURAB", "HRURAB", JdeDataType.Numeric),
        new JdeField("HRURAT", "HRURAT", JdeDataType.Numeric),
        new JdeField("HRURCD", "HRURCD", JdeDataType.String, 4),
        new JdeField("HRURDT", "HRURDT", JdeDataType.Numeric),
        new JdeField("HRURRF", "HRURRF", JdeDataType.String, 30),
        new JdeField("HRWAB", "HRWAB", JdeDataType.Numeric),
        new JdeField("HRWNUM", "HRWNUM", JdeDataType.Numeric),
        new JdeField("HRWCD", "HRWCD", JdeDataType.String, 6),
        new JdeField("HRWMDT", "HRWMDT", JdeDataType.Numeric),
        new JdeField("HRWRF", "HRWRF", JdeDataType.String, 60),
        new JdeField("HRUSER", "HRUSER", JdeDataType.String, 20),
        new JdeField("HRUPMJ", "HRUPMJ", JdeDataType.Numeric),
        new JdeField("HRUPMT", "HRUPMT", JdeDataType.Numeric),
        new JdeField("HRJOBN", "HRJOBN", JdeDataType.String, 20),
        new JdeField("HRMKEY", "HRMKEY", JdeDataType.String, 30),
        new JdeField("HRPID", "HRPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B97_0", "Primary Key on HRWOPID, HRUKID", new[] { "HRWOPID", "HRUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
