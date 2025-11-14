using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085605W - .
/// </summary>
public class F085605W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSAN8.
        /// </summary>
        public const string VSAN8 = "VSAN8";

        /// <summary>
        /// VSALPH.
        /// </summary>
        public const string VSALPH = "VSALPH";

        /// <summary>
        /// VSOFTP.
        /// </summary>
        public const string VSOFTP = "VSOFTP";

        /// <summary>
        /// VSHM02.
        /// </summary>
        public const string VSHM02 = "VSHM02";

        /// <summary>
        /// VSHM03.
        /// </summary>
        public const string VSHM03 = "VSHM03";

        /// <summary>
        /// VSMLDT.
        /// </summary>
        public const string VSMLDT = "VSMLDT";

        /// <summary>
        /// VSEECD.
        /// </summary>
        public const string VSEECD = "VSEECD";

        /// <summary>
        /// VSEVET.
        /// </summary>
        public const string VSEVET = "VSEVET";

        /// <summary>
        /// VSAT1.
        /// </summary>
        public const string VSAT1 = "VSAT1";

        /// <summary>
        /// VSFMIR.
        /// </summary>
        public const string VSFMIR = "VSFMIR";

        /// <summary>
        /// VSACFL.
        /// </summary>
        public const string VSACFL = "VSACFL";

        /// <summary>
        /// VSESIGN.
        /// </summary>
        public const string VSESIGN = "VSESIGN";

        /// <summary>
        /// VSAPRV.
        /// </summary>
        public const string VSAPRV = "VSAPRV";

        /// <summary>
        /// VSAPRD.
        /// </summary>
        public const string VSAPRD = "VSAPRD";

        /// <summary>
        /// VSWFS.
        /// </summary>
        public const string VSWFS = "VSWFS";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSUPMT.
        /// </summary>
        public const string VSUPMT = "VSUPMT";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F085605W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSAN8", "VSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VSALPH", "VSALPH", JdeDataType.String, 80),
        new JdeField("VSOFTP", "VSOFTP", JdeDataType.String, 2),
        new JdeField("VSHM02", "VSHM02", JdeDataType.String, 2),
        new JdeField("VSHM03", "VSHM03", JdeDataType.String, 2),
        new JdeField("VSMLDT", "VSMLDT", JdeDataType.Numeric),
        new JdeField("VSEECD", "VSEECD", JdeDataType.String, 6),
        new JdeField("VSEVET", "VSEVET", JdeDataType.Numeric),
        new JdeField("VSAT1", "VSAT1", JdeDataType.String, 6),
        new JdeField("VSFMIR", "VSFMIR", JdeDataType.String, 2),
        new JdeField("VSACFL", "VSACFL", JdeDataType.String, 2),
        new JdeField("VSESIGN", "VSESIGN", JdeDataType.String, 32),
        new JdeField("VSAPRV", "VSAPRV", JdeDataType.Numeric),
        new JdeField("VSAPRD", "VSAPRD", JdeDataType.Numeric),
        new JdeField("VSWFS", "VSWFS", JdeDataType.String, 2),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSUPMT", "VSUPMT", JdeDataType.Numeric),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085605W_0", "Primary Key on VSAN8", new[] { "VSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
