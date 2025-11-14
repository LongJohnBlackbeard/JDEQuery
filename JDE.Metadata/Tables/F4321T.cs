using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4321T - .
/// </summary>
public class F4321T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBKCOO.
        /// </summary>
        public const string PBKCOO = "PBKCOO";

        /// <summary>
        /// PBDOCO.
        /// </summary>
        public const string PBDOCO = "PBDOCO";

        /// <summary>
        /// PBDCTO.
        /// </summary>
        public const string PBDCTO = "PBDCTO";

        /// <summary>
        /// PBSFXO.
        /// </summary>
        public const string PBSFXO = "PBSFXO";

        /// <summary>
        /// PBLNID.
        /// </summary>
        public const string PBLNID = "PBLNID";

        /// <summary>
        /// PBLTLV.
        /// </summary>
        public const string PBLTLV = "PBLTLV";

        /// <summary>
        /// PBDCAP.
        /// </summary>
        public const string PBDCAP = "PBDCAP";

        /// <summary>
        /// PBDA08.
        /// </summary>
        public const string PBDA08 = "PBDA08";

        /// <summary>
        /// PBRCPD.
        /// </summary>
        public const string PBRCPD = "PBRCPD";

        /// <summary>
        /// PBVLOT.
        /// </summary>
        public const string PBVLOT = "PBVLOT";

        /// <summary>
        /// PBMXQT.
        /// </summary>
        public const string PBMXQT = "PBMXQT";

        /// <summary>
        /// PBMWDH.
        /// </summary>
        public const string PBMWDH = "PBMWDH";
    }

    /// <inheritdoc />
    public override string TableName => "F4321T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBKCOO", "PBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PBDOCO", "PBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PBDCTO", "PBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PBSFXO", "PBSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PBLNID", "PBLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBLTLV", "PBLTLV", JdeDataType.Numeric),
        new JdeField("PBDCAP", "PBDCAP", JdeDataType.Numeric),
        new JdeField("PBDA08", "PBDA08", JdeDataType.String, 2),
        new JdeField("PBRCPD", "PBRCPD", JdeDataType.Numeric),
        new JdeField("PBVLOT", "PBVLOT", JdeDataType.Numeric),
        new JdeField("PBMXQT", "PBMXQT", JdeDataType.Numeric),
        new JdeField("PBMWDH", "PBMWDH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4321T_0", "Primary Key on PBDOCO, PBDCTO, PBKCOO, PBSFXO, PBLNID", new[] { "PBDOCO", "PBDCTO", "PBKCOO", "PBSFXO", "PBLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
