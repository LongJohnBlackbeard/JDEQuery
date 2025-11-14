using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39120 - .
/// </summary>
public class F39120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFCO.
        /// </summary>
        public const string TFCO = "TFCO";

        /// <summary>
        /// TFMCU.
        /// </summary>
        public const string TFMCU = "TFMCU";

        /// <summary>
        /// TFITPL.
        /// </summary>
        public const string TFITPL = "TFITPL";

        /// <summary>
        /// TFITM.
        /// </summary>
        public const string TFITM = "TFITM";

        /// <summary>
        /// TFCRCD.
        /// </summary>
        public const string TFCRCD = "TFCRCD";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFEV01.
        /// </summary>
        public const string TFEV01 = "TFEV01";

        /// <summary>
        /// TFTRUM.
        /// </summary>
        public const string TFTRUM = "TFTRUM";

        /// <summary>
        /// TFTRQT.
        /// </summary>
        public const string TFTRQT = "TFTRQT";

        /// <summary>
        /// TFUNCS.
        /// </summary>
        public const string TFUNCS = "TFUNCS";

        /// <summary>
        /// TFPAID.
        /// </summary>
        public const string TFPAID = "TFPAID";

        /// <summary>
        /// TFTNTP.
        /// </summary>
        public const string TFTNTP = "TFTNTP";

        /// <summary>
        /// TFTRDJ.
        /// </summary>
        public const string TFTRDJ = "TFTRDJ";

        /// <summary>
        /// TFSVYR.
        /// </summary>
        public const string TFSVYR = "TFSVYR";

        /// <summary>
        /// TFPNC.
        /// </summary>
        public const string TFPNC = "TFPNC";

        /// <summary>
        /// TFDOCO.
        /// </summary>
        public const string TFDOCO = "TFDOCO";

        /// <summary>
        /// TFDCTO.
        /// </summary>
        public const string TFDCTO = "TFDCTO";

        /// <summary>
        /// TFLNID.
        /// </summary>
        public const string TFLNID = "TFLNID";

        /// <summary>
        /// TFNLIN.
        /// </summary>
        public const string TFNLIN = "TFNLIN";

        /// <summary>
        /// TFOITM.
        /// </summary>
        public const string TFOITM = "TFOITM";

        /// <summary>
        /// TFFYR.
        /// </summary>
        public const string TFFYR = "TFFYR";

        /// <summary>
        /// TFPN.
        /// </summary>
        public const string TFPN = "TFPN";

        /// <summary>
        /// TFDGL.
        /// </summary>
        public const string TFDGL = "TFDGL";

        /// <summary>
        /// TFCALD.
        /// </summary>
        public const string TFCALD = "TFCALD";

        /// <summary>
        /// TFCDEC.
        /// </summary>
        public const string TFCDEC = "TFCDEC";

        /// <summary>
        /// TFUKID.
        /// </summary>
        public const string TFUKID = "TFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F39120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFCO", "TFCO", JdeDataType.String, 10, true, true),
        new JdeField("TFMCU", "TFMCU", JdeDataType.String, 24, true, true),
        new JdeField("TFITPL", "TFITPL", JdeDataType.String, 20, true, true),
        new JdeField("TFITM", "TFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TFCRCD", "TFCRCD", JdeDataType.String, 6, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4),
        new JdeField("TFEV01", "TFEV01", JdeDataType.String, 2),
        new JdeField("TFTRUM", "TFTRUM", JdeDataType.String, 4),
        new JdeField("TFTRQT", "TFTRQT", JdeDataType.Numeric),
        new JdeField("TFUNCS", "TFUNCS", JdeDataType.Numeric),
        new JdeField("TFPAID", "TFPAID", JdeDataType.Numeric),
        new JdeField("TFTNTP", "TFTNTP", JdeDataType.String, 2),
        new JdeField("TFTRDJ", "TFTRDJ", JdeDataType.Numeric),
        new JdeField("TFSVYR", "TFSVYR", JdeDataType.Numeric),
        new JdeField("TFPNC", "TFPNC", JdeDataType.Numeric),
        new JdeField("TFDOCO", "TFDOCO", JdeDataType.Numeric),
        new JdeField("TFDCTO", "TFDCTO", JdeDataType.String, 4),
        new JdeField("TFLNID", "TFLNID", JdeDataType.Numeric),
        new JdeField("TFNLIN", "TFNLIN", JdeDataType.Numeric),
        new JdeField("TFOITM", "TFOITM", JdeDataType.Numeric),
        new JdeField("TFFYR", "TFFYR", JdeDataType.Numeric),
        new JdeField("TFPN", "TFPN", JdeDataType.Numeric),
        new JdeField("TFDGL", "TFDGL", JdeDataType.Numeric),
        new JdeField("TFCALD", "TFCALD", JdeDataType.String, 4),
        new JdeField("TFCDEC", "TFCDEC", JdeDataType.String, 2),
        new JdeField("TFUKID", "TFUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39120_0", "Primary Key on TFCO, TFMCU, TFITPL, TFITM, TFCRCD, TFUKID", new[] { "TFCO", "TFMCU", "TFITPL", "TFITM", "TFCRCD", "TFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39120_2", "Index on TFUKID", new[] { "TFUKID" })
    };
}
