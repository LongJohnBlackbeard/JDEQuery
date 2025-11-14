using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069226 - .
/// </summary>
public class F069226 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YHCO.
        /// </summary>
        public const string YHCO = "YHCO";

        /// <summary>
        /// YHTARA.
        /// </summary>
        public const string YHTARA = "YHTARA";

        /// <summary>
        /// YHPTAX.
        /// </summary>
        public const string YHPTAX = "YHPTAX";

        /// <summary>
        /// YHUCRT.
        /// </summary>
        public const string YHUCRT = "YHUCRT";

        /// <summary>
        /// YHUCLM.
        /// </summary>
        public const string YHUCLM = "YHUCLM";

        /// <summary>
        /// YHPPT.
        /// </summary>
        public const string YHPPT = "YHPPT";

        /// <summary>
        /// YHUSER.
        /// </summary>
        public const string YHUSER = "YHUSER";

        /// <summary>
        /// YHPID.
        /// </summary>
        public const string YHPID = "YHPID";

        /// <summary>
        /// YHUPMJ.
        /// </summary>
        public const string YHUPMJ = "YHUPMJ";

        /// <summary>
        /// YHMHRS.
        /// </summary>
        public const string YHMHRS = "YHMHRS";

        /// <summary>
        /// YHMPAY.
        /// </summary>
        public const string YHMPAY = "YHMPAY";

        /// <summary>
        /// YHEFTB.
        /// </summary>
        public const string YHEFTB = "YHEFTB";

        /// <summary>
        /// YHEFTE.
        /// </summary>
        public const string YHEFTE = "YHEFTE";

        /// <summary>
        /// YHUCRR.
        /// </summary>
        public const string YHUCRR = "YHUCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F069226";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YHCO", "YHCO", JdeDataType.String, 10, true, true),
        new JdeField("YHTARA", "YHTARA", JdeDataType.String, 20, true, true),
        new JdeField("YHPTAX", "YHPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YHUCRT", "YHUCRT", JdeDataType.Numeric),
        new JdeField("YHUCLM", "YHUCLM", JdeDataType.Numeric, null, true, true),
        new JdeField("YHPPT", "YHPPT", JdeDataType.String, 2),
        new JdeField("YHUSER", "YHUSER", JdeDataType.String, 20),
        new JdeField("YHPID", "YHPID", JdeDataType.String, 20),
        new JdeField("YHUPMJ", "YHUPMJ", JdeDataType.Numeric),
        new JdeField("YHMHRS", "YHMHRS", JdeDataType.Numeric),
        new JdeField("YHMPAY", "YHMPAY", JdeDataType.Numeric),
        new JdeField("YHEFTB", "YHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("YHEFTE", "YHEFTE", JdeDataType.Numeric),
        new JdeField("YHUCRR", "YHUCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069226_0", "Primary Key on YHCO, YHPTAX, YHEFTB, YHTARA, YHUCLM", new[] { "YHCO", "YHPTAX", "YHEFTB", "YHTARA", "YHUCLM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069226_2", "Index on YHCO, YHPTAX, YHTARA, YHEFTB, YHUCLM", new[] { "YHCO", "YHPTAX", "YHTARA", "YHEFTB", "YHUCLM" })
    };
}
