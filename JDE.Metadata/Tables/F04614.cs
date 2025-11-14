using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04614 - .
/// </summary>
public class F04614 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTDPRE.
        /// </summary>
        public const string CTDPRE = "CTDPRE";

        /// <summary>
        /// CTCO.
        /// </summary>
        public const string CTCO = "CTCO";

        /// <summary>
        /// CTCBNP.
        /// </summary>
        public const string CTCBNP = "CTCBNP";

        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTCBNR.
        /// </summary>
        public const string CTCBNR = "CTCBNR";

        /// <summary>
        /// CTSINI.
        /// </summary>
        public const string CTSINI = "CTSINI";

        /// <summary>
        /// CTAA.
        /// </summary>
        public const string CTAA = "CTAA";

        /// <summary>
        /// CTRIND.
        /// </summary>
        public const string CTRIND = "CTRIND";

        /// <summary>
        /// CTNOS.
        /// </summary>
        public const string CTNOS = "CTNOS";

        /// <summary>
        /// CTRTYPC.
        /// </summary>
        public const string CTRTYPC = "CTRTYPC";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F04614";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTDPRE", "CTDPRE", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCO", "CTCO", JdeDataType.String, 10, true, true),
        new JdeField("CTCBNP", "CTCBNP", JdeDataType.String, 30),
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCBNR", "CTCBNR", JdeDataType.String, 30),
        new JdeField("CTSINI", "CTSINI", JdeDataType.String, 2),
        new JdeField("CTAA", "CTAA", JdeDataType.Numeric),
        new JdeField("CTRIND", "CTRIND", JdeDataType.String, 2),
        new JdeField("CTNOS", "CTNOS", JdeDataType.Numeric),
        new JdeField("CTRTYPC", "CTRTYPC", JdeDataType.String, 2, true, true),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04614_0", "Primary Key on CTAN8, CTCO, CTRTYPC, CTDPRE", new[] { "CTAN8", "CTCO", "CTRTYPC", "CTDPRE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F04614_2", "Index on CTCO, CTRIND, CTDPRE", new[] { "CTCO", "CTRIND", "CTDPRE" })
    };
}
