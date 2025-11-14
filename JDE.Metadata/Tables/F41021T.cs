using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021T - .
/// </summary>
public class F41021T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTITM.
        /// </summary>
        public const string LTITM = "LTITM";

        /// <summary>
        /// LTLITM.
        /// </summary>
        public const string LTLITM = "LTLITM";

        /// <summary>
        /// LTAITM.
        /// </summary>
        public const string LTAITM = "LTAITM";

        /// <summary>
        /// LTMCU.
        /// </summary>
        public const string LTMCU = "LTMCU";

        /// <summary>
        /// LTLOCN.
        /// </summary>
        public const string LTLOCN = "LTLOCN";

        /// <summary>
        /// LTLOTN.
        /// </summary>
        public const string LTLOTN = "LTLOTN";

        /// <summary>
        /// LTPNS.
        /// </summary>
        public const string LTPNS = "LTPNS";

        /// <summary>
        /// LTPMPN.
        /// </summary>
        public const string LTPMPN = "LTPMPN";

        /// <summary>
        /// LTPQOH.
        /// </summary>
        public const string LTPQOH = "LTPQOH";

        /// <summary>
        /// LTSQOH.
        /// </summary>
        public const string LTSQOH = "LTSQOH";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTTDAY.
        /// </summary>
        public const string LTTDAY = "LTTDAY";

        /// <summary>
        /// LTURDT.
        /// </summary>
        public const string LTURDT = "LTURDT";

        /// <summary>
        /// LTURCD.
        /// </summary>
        public const string LTURCD = "LTURCD";

        /// <summary>
        /// LTURAT.
        /// </summary>
        public const string LTURAT = "LTURAT";

        /// <summary>
        /// LTURRF.
        /// </summary>
        public const string LTURRF = "LTURRF";

        /// <summary>
        /// LTURAB.
        /// </summary>
        public const string LTURAB = "LTURAB";

        /// <summary>
        /// LTFFU3.
        /// </summary>
        public const string LTFFU3 = "LTFFU3";

        /// <summary>
        /// LTFFU4.
        /// </summary>
        public const string LTFFU4 = "LTFFU4";

        /// <summary>
        /// LTTFUDJ.
        /// </summary>
        public const string LTTFUDJ = "LTTFUDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F41021T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTITM", "LTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LTLITM", "LTLITM", JdeDataType.String, 50),
        new JdeField("LTAITM", "LTAITM", JdeDataType.String, 50),
        new JdeField("LTMCU", "LTMCU", JdeDataType.String, 24, true, true),
        new JdeField("LTLOCN", "LTLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LTLOTN", "LTLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LTPNS", "LTPNS", JdeDataType.Numeric, null, true, true),
        new JdeField("LTPMPN", "LTPMPN", JdeDataType.String, 60),
        new JdeField("LTPQOH", "LTPQOH", JdeDataType.Numeric),
        new JdeField("LTSQOH", "LTSQOH", JdeDataType.Numeric),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTTDAY", "LTTDAY", JdeDataType.Numeric),
        new JdeField("LTURDT", "LTURDT", JdeDataType.Numeric),
        new JdeField("LTURCD", "LTURCD", JdeDataType.String, 4),
        new JdeField("LTURAT", "LTURAT", JdeDataType.Numeric),
        new JdeField("LTURRF", "LTURRF", JdeDataType.String, 30),
        new JdeField("LTURAB", "LTURAB", JdeDataType.Numeric),
        new JdeField("LTFFU3", "LTFFU3", JdeDataType.String, 20),
        new JdeField("LTFFU4", "LTFFU4", JdeDataType.Numeric),
        new JdeField("LTTFUDJ", "LTTFUDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021T_0", "Primary Key on LTITM, LTMCU, LTLOCN, LTLOTN, LTPNS", new[] { "LTITM", "LTMCU", "LTLOCN", "LTLOTN", "LTPNS" }, isUnique: true, isPrimaryKey: true)
    };
}
