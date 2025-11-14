using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q213 - .
/// </summary>
public class F43Q213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBEVNU.
        /// </summary>
        public const string PBEVNU = "PBEVNU";

        /// <summary>
        /// PBDCTO.
        /// </summary>
        public const string PBDCTO = "PBDCTO";

        /// <summary>
        /// PBKCOO.
        /// </summary>
        public const string PBKCOO = "PBKCOO";

        /// <summary>
        /// PBEVLN.
        /// </summary>
        public const string PBEVLN = "PBEVLN";

        /// <summary>
        /// PBBIDQN.
        /// </summary>
        public const string PBBIDQN = "PBBIDQN";

        /// <summary>
        /// PBTRNB.
        /// </summary>
        public const string PBTRNB = "PBTRNB";

        /// <summary>
        /// PBPBQTY.
        /// </summary>
        public const string PBPBQTY = "PBPBQTY";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";

        /// <summary>
        /// PBTORG.
        /// </summary>
        public const string PBTORG = "PBTORG";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBTDAY.
        /// </summary>
        public const string PBTDAY = "PBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBEVNU", "PBEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("PBDCTO", "PBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PBKCOO", "PBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PBEVLN", "PBEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PBBIDQN", "PBBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("PBTRNB", "PBTRNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PBPBQTY", "PBPBQTY", JdeDataType.Numeric),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30),
        new JdeField("PBTORG", "PBTORG", JdeDataType.String, 20),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBTDAY", "PBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q213_0", "Primary Key on PBEVNU, PBDCTO, PBKCOO, PBEVLN, PBBIDQN, PBTRNB", new[] { "PBEVNU", "PBDCTO", "PBKCOO", "PBEVLN", "PBBIDQN", "PBTRNB" }, isUnique: true, isPrimaryKey: true)
    };
}
