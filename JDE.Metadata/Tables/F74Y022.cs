using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y022 - .
/// </summary>
public class F74Y022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IAY74IDEC.
        /// </summary>
        public const string IAY74IDEC = "IAY74IDEC";

        /// <summary>
        /// IAKCOO.
        /// </summary>
        public const string IAKCOO = "IAKCOO";

        /// <summary>
        /// IADCTO.
        /// </summary>
        public const string IADCTO = "IADCTO";

        /// <summary>
        /// IADOCO.
        /// </summary>
        public const string IADOCO = "IADOCO";

        /// <summary>
        /// IAY74SEC.
        /// </summary>
        public const string IAY74SEC = "IAY74SEC";

        /// <summary>
        /// IAY74MOS.
        /// </summary>
        public const string IAY74MOS = "IAY74MOS";

        /// <summary>
        /// IAY74MOC.
        /// </summary>
        public const string IAY74MOC = "IAY74MOC";

        /// <summary>
        /// IAY74PCTR.
        /// </summary>
        public const string IAY74PCTR = "IAY74PCTR";

        /// <summary>
        /// IAY74IDEN.
        /// </summary>
        public const string IAY74IDEN = "IAY74IDEN";

        /// <summary>
        /// IAY74SSEQ.
        /// </summary>
        public const string IAY74SSEQ = "IAY74SSEQ";

        /// <summary>
        /// IAY74CUOF.
        /// </summary>
        public const string IAY74CUOF = "IAY74CUOF";

        /// <summary>
        /// IAY74IPN.
        /// </summary>
        public const string IAY74IPN = "IAY74IPN";

        /// <summary>
        /// IAY74IYR.
        /// </summary>
        public const string IAY74IYR = "IAY74IYR";

        /// <summary>
        /// IAUSER.
        /// </summary>
        public const string IAUSER = "IAUSER";

        /// <summary>
        /// IAPID.
        /// </summary>
        public const string IAPID = "IAPID";

        /// <summary>
        /// IAJOBN.
        /// </summary>
        public const string IAJOBN = "IAJOBN";

        /// <summary>
        /// IAUPMJ.
        /// </summary>
        public const string IAUPMJ = "IAUPMJ";

        /// <summary>
        /// IAUPMT.
        /// </summary>
        public const string IAUPMT = "IAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IAY74IDEC", "IAY74IDEC", JdeDataType.Numeric, null, true, true),
        new JdeField("IAKCOO", "IAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IADCTO", "IADCTO", JdeDataType.String, 4, true, true),
        new JdeField("IADOCO", "IADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IAY74SEC", "IAY74SEC", JdeDataType.String, 20, true, true),
        new JdeField("IAY74MOS", "IAY74MOS", JdeDataType.String, 2, true, true),
        new JdeField("IAY74MOC", "IAY74MOC", JdeDataType.String, 2, true, true),
        new JdeField("IAY74PCTR", "IAY74PCTR", JdeDataType.String, 6, true, true),
        new JdeField("IAY74IDEN", "IAY74IDEN", JdeDataType.String, 20),
        new JdeField("IAY74SSEQ", "IAY74SSEQ", JdeDataType.Numeric),
        new JdeField("IAY74CUOF", "IAY74CUOF", JdeDataType.Numeric),
        new JdeField("IAY74IPN", "IAY74IPN", JdeDataType.Numeric),
        new JdeField("IAY74IYR", "IAY74IYR", JdeDataType.Numeric),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAJOBN", "IAJOBN", JdeDataType.String, 20),
        new JdeField("IAUPMJ", "IAUPMJ", JdeDataType.Numeric),
        new JdeField("IAUPMT", "IAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y022_0", "Primary Key on IAY74IDEC, IAKCOO, IADCTO, IADOCO, IAY74SEC, IAY74MOS, IAY74MOC, IAY74PCTR", new[] { "IAY74IDEC", "IAKCOO", "IADCTO", "IADOCO", "IAY74SEC", "IAY74MOS", "IAY74MOC", "IAY74PCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
