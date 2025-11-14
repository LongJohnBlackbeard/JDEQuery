using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q15 - .
/// </summary>
public class F43Q15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECEVNU.
        /// </summary>
        public const string ECEVNU = "ECEVNU";

        /// <summary>
        /// ECDCTO.
        /// </summary>
        public const string ECDCTO = "ECDCTO";

        /// <summary>
        /// ECKCOO.
        /// </summary>
        public const string ECKCOO = "ECKCOO";

        /// <summary>
        /// ECSEQUEN.
        /// </summary>
        public const string ECSEQUEN = "ECSEQUEN";

        /// <summary>
        /// ECCRCD.
        /// </summary>
        public const string ECCRCD = "ECCRCD";

        /// <summary>
        /// ECCRR.
        /// </summary>
        public const string ECCRR = "ECCRR";

        /// <summary>
        /// ECURCD.
        /// </summary>
        public const string ECURCD = "ECURCD";

        /// <summary>
        /// ECURDT.
        /// </summary>
        public const string ECURDT = "ECURDT";

        /// <summary>
        /// ECURAT.
        /// </summary>
        public const string ECURAT = "ECURAT";

        /// <summary>
        /// ECURAB.
        /// </summary>
        public const string ECURAB = "ECURAB";

        /// <summary>
        /// ECURRF.
        /// </summary>
        public const string ECURRF = "ECURRF";

        /// <summary>
        /// ECTORG.
        /// </summary>
        public const string ECTORG = "ECTORG";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECTDAY.
        /// </summary>
        public const string ECTDAY = "ECTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECEVNU", "ECEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("ECDCTO", "ECDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ECKCOO", "ECKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ECSEQUEN", "ECSEQUEN", JdeDataType.Numeric, null, true, true),
        new JdeField("ECCRCD", "ECCRCD", JdeDataType.String, 6),
        new JdeField("ECCRR", "ECCRR", JdeDataType.Numeric),
        new JdeField("ECURCD", "ECURCD", JdeDataType.String, 4),
        new JdeField("ECURDT", "ECURDT", JdeDataType.Numeric),
        new JdeField("ECURAT", "ECURAT", JdeDataType.Numeric),
        new JdeField("ECURAB", "ECURAB", JdeDataType.Numeric),
        new JdeField("ECURRF", "ECURRF", JdeDataType.String, 30),
        new JdeField("ECTORG", "ECTORG", JdeDataType.String, 20),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECTDAY", "ECTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q15_0", "Primary Key on ECEVNU, ECDCTO, ECKCOO, ECSEQUEN", new[] { "ECEVNU", "ECDCTO", "ECKCOO", "ECSEQUEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q15_2", "Index on ECEVNU, ECDCTO, ECKCOO", new[] { "ECEVNU", "ECDCTO", "ECKCOO" }),
        new JdeIndex("F43Q15_4", "Index on ECEVNU, ECDCTO, ECKCOO, ECCRCD", new[] { "ECEVNU", "ECDCTO", "ECKCOO", "ECCRCD" })
    };
}
