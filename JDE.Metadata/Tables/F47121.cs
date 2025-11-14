using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47121 - .
/// </summary>
public class F47121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M1EDTY.
        /// </summary>
        public const string M1EDTY = "M1EDTY";

        /// <summary>
        /// M1EDSQ.
        /// </summary>
        public const string M1EDSQ = "M1EDSQ";

        /// <summary>
        /// M1EKCO.
        /// </summary>
        public const string M1EKCO = "M1EKCO";

        /// <summary>
        /// M1EDOC.
        /// </summary>
        public const string M1EDOC = "M1EDOC";

        /// <summary>
        /// M1EDCT.
        /// </summary>
        public const string M1EDCT = "M1EDCT";

        /// <summary>
        /// M1EDLN.
        /// </summary>
        public const string M1EDLN = "M1EDLN";

        /// <summary>
        /// M1EDST.
        /// </summary>
        public const string M1EDST = "M1EDST";

        /// <summary>
        /// M1EDFT.
        /// </summary>
        public const string M1EDFT = "M1EDFT";

        /// <summary>
        /// M1EDDT.
        /// </summary>
        public const string M1EDDT = "M1EDDT";

        /// <summary>
        /// M1EDER.
        /// </summary>
        public const string M1EDER = "M1EDER";

        /// <summary>
        /// M1EDDL.
        /// </summary>
        public const string M1EDDL = "M1EDDL";

        /// <summary>
        /// M1EDSP.
        /// </summary>
        public const string M1EDSP = "M1EDSP";

        /// <summary>
        /// M1EDBT.
        /// </summary>
        public const string M1EDBT = "M1EDBT";

        /// <summary>
        /// M1PNID.
        /// </summary>
        public const string M1PNID = "M1PNID";

        /// <summary>
        /// M1THCD.
        /// </summary>
        public const string M1THCD = "M1THCD";

        /// <summary>
        /// M1AN8.
        /// </summary>
        public const string M1AN8 = "M1AN8";

        /// <summary>
        /// M1DTFR.
        /// </summary>
        public const string M1DTFR = "M1DTFR";

        /// <summary>
        /// M1DTTO.
        /// </summary>
        public const string M1DTTO = "M1DTTO";

        /// <summary>
        /// M1VR01.
        /// </summary>
        public const string M1VR01 = "M1VR01";

        /// <summary>
        /// M1URCD.
        /// </summary>
        public const string M1URCD = "M1URCD";

        /// <summary>
        /// M1URDT.
        /// </summary>
        public const string M1URDT = "M1URDT";

        /// <summary>
        /// M1URAT.
        /// </summary>
        public const string M1URAT = "M1URAT";

        /// <summary>
        /// M1URAB.
        /// </summary>
        public const string M1URAB = "M1URAB";

        /// <summary>
        /// M1URRF.
        /// </summary>
        public const string M1URRF = "M1URRF";

        /// <summary>
        /// M1TORG.
        /// </summary>
        public const string M1TORG = "M1TORG";

        /// <summary>
        /// M1USER.
        /// </summary>
        public const string M1USER = "M1USER";

        /// <summary>
        /// M1PID.
        /// </summary>
        public const string M1PID = "M1PID";

        /// <summary>
        /// M1JOBN.
        /// </summary>
        public const string M1JOBN = "M1JOBN";

        /// <summary>
        /// M1UPMJ.
        /// </summary>
        public const string M1UPMJ = "M1UPMJ";

        /// <summary>
        /// M1TDAY.
        /// </summary>
        public const string M1TDAY = "M1TDAY";

        /// <summary>
        /// M1GAN8.
        /// </summary>
        public const string M1GAN8 = "M1GAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F47121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M1EDTY", "M1EDTY", JdeDataType.String, 2),
        new JdeField("M1EDSQ", "M1EDSQ", JdeDataType.Numeric),
        new JdeField("M1EKCO", "M1EKCO", JdeDataType.String, 10, true, true),
        new JdeField("M1EDOC", "M1EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("M1EDCT", "M1EDCT", JdeDataType.String, 4, true, true),
        new JdeField("M1EDLN", "M1EDLN", JdeDataType.Numeric),
        new JdeField("M1EDST", "M1EDST", JdeDataType.String, 12),
        new JdeField("M1EDFT", "M1EDFT", JdeDataType.String, 20),
        new JdeField("M1EDDT", "M1EDDT", JdeDataType.Numeric),
        new JdeField("M1EDER", "M1EDER", JdeDataType.String, 2),
        new JdeField("M1EDDL", "M1EDDL", JdeDataType.Numeric),
        new JdeField("M1EDSP", "M1EDSP", JdeDataType.String, 2),
        new JdeField("M1EDBT", "M1EDBT", JdeDataType.String, 30),
        new JdeField("M1PNID", "M1PNID", JdeDataType.String, 30),
        new JdeField("M1THCD", "M1THCD", JdeDataType.String, 2),
        new JdeField("M1AN8", "M1AN8", JdeDataType.Numeric),
        new JdeField("M1DTFR", "M1DTFR", JdeDataType.Numeric),
        new JdeField("M1DTTO", "M1DTTO", JdeDataType.Numeric),
        new JdeField("M1VR01", "M1VR01", JdeDataType.String, 50),
        new JdeField("M1URCD", "M1URCD", JdeDataType.String, 4),
        new JdeField("M1URDT", "M1URDT", JdeDataType.Numeric),
        new JdeField("M1URAT", "M1URAT", JdeDataType.Numeric),
        new JdeField("M1URAB", "M1URAB", JdeDataType.Numeric),
        new JdeField("M1URRF", "M1URRF", JdeDataType.String, 30),
        new JdeField("M1TORG", "M1TORG", JdeDataType.String, 20),
        new JdeField("M1USER", "M1USER", JdeDataType.String, 20),
        new JdeField("M1PID", "M1PID", JdeDataType.String, 20),
        new JdeField("M1JOBN", "M1JOBN", JdeDataType.String, 20),
        new JdeField("M1UPMJ", "M1UPMJ", JdeDataType.Numeric),
        new JdeField("M1TDAY", "M1TDAY", JdeDataType.Numeric),
        new JdeField("M1GAN8", "M1GAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47121_0", "Primary Key on M1EDOC, M1EDCT, M1EKCO", new[] { "M1EDOC", "M1EDCT", "M1EKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
