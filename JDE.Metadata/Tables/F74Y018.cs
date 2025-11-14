using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y018 - .
/// </summary>
public class F74Y018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// IASFXO.
        /// </summary>
        public const string IASFXO = "IASFXO";

        /// <summary>
        /// IALNID.
        /// </summary>
        public const string IALNID = "IALNID";

        /// <summary>
        /// IAY74IDEC.
        /// </summary>
        public const string IAY74IDEC = "IAY74IDEC";

        /// <summary>
        /// IAY74OPTY.
        /// </summary>
        public const string IAY74OPTY = "IAY74OPTY";

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
        /// IAY74INCN.
        /// </summary>
        public const string IAY74INCN = "IAY74INCN";

        /// <summary>
        /// IAOKCO.
        /// </summary>
        public const string IAOKCO = "IAOKCO";

        /// <summary>
        /// IAODCT.
        /// </summary>
        public const string IAODCT = "IAODCT";

        /// <summary>
        /// IAODOC.
        /// </summary>
        public const string IAODOC = "IAODOC";

        /// <summary>
        /// IAVINV.
        /// </summary>
        public const string IAVINV = "IAVINV";

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
    public override string TableName => "F74Y018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IAKCOO", "IAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IADCTO", "IADCTO", JdeDataType.String, 4, true, true),
        new JdeField("IADOCO", "IADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IASFXO", "IASFXO", JdeDataType.String, 6, true, true),
        new JdeField("IALNID", "IALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IAY74IDEC", "IAY74IDEC", JdeDataType.Numeric),
        new JdeField("IAY74OPTY", "IAY74OPTY", JdeDataType.String, 2),
        new JdeField("IAY74SEC", "IAY74SEC", JdeDataType.String, 20),
        new JdeField("IAY74MOS", "IAY74MOS", JdeDataType.String, 2),
        new JdeField("IAY74MOC", "IAY74MOC", JdeDataType.String, 2),
        new JdeField("IAY74PCTR", "IAY74PCTR", JdeDataType.String, 6),
        new JdeField("IAY74INCN", "IAY74INCN", JdeDataType.String, 2),
        new JdeField("IAOKCO", "IAOKCO", JdeDataType.String, 10),
        new JdeField("IAODCT", "IAODCT", JdeDataType.String, 4),
        new JdeField("IAODOC", "IAODOC", JdeDataType.Numeric),
        new JdeField("IAVINV", "IAVINV", JdeDataType.String, 50),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAJOBN", "IAJOBN", JdeDataType.String, 20),
        new JdeField("IAUPMJ", "IAUPMJ", JdeDataType.Numeric),
        new JdeField("IAUPMT", "IAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y018_0", "Primary Key on IAKCOO, IADCTO, IADOCO, IASFXO, IALNID", new[] { "IAKCOO", "IADCTO", "IADOCO", "IASFXO", "IALNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y018_2", "Index on IAY74IDEC", new[] { "IAY74IDEC" })
    };
}
