using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39121W - .
/// </summary>
public class F39121W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AQITM.
        /// </summary>
        public const string AQITM = "AQITM";

        /// <summary>
        /// AQCO.
        /// </summary>
        public const string AQCO = "AQCO";

        /// <summary>
        /// AQMCU.
        /// </summary>
        public const string AQMCU = "AQMCU";

        /// <summary>
        /// AQQRCT.
        /// </summary>
        public const string AQQRCT = "AQQRCT";

        /// <summary>
        /// AQITLT.
        /// </summary>
        public const string AQITLT = "AQITLT";

        /// <summary>
        /// AQDTO.
        /// </summary>
        public const string AQDTO = "AQDTO";

        /// <summary>
        /// AQUOM.
        /// </summary>
        public const string AQUOM = "AQUOM";

        /// <summary>
        /// AQSTUM.
        /// </summary>
        public const string AQSTUM = "AQSTUM";

        /// <summary>
        /// AQUNCS.
        /// </summary>
        public const string AQUNCS = "AQUNCS";

        /// <summary>
        /// AQECST.
        /// </summary>
        public const string AQECST = "AQECST";

        /// <summary>
        /// AQTRDJ.
        /// </summary>
        public const string AQTRDJ = "AQTRDJ";

        /// <summary>
        /// AQDGL.
        /// </summary>
        public const string AQDGL = "AQDGL";

        /// <summary>
        /// AQUKID.
        /// </summary>
        public const string AQUKID = "AQUKID";

        /// <summary>
        /// AQFILE.
        /// </summary>
        public const string AQFILE = "AQFILE";
    }

    /// <inheritdoc />
    public override string TableName => "F39121W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AQITM", "AQITM", JdeDataType.Numeric),
        new JdeField("AQCO", "AQCO", JdeDataType.String, 10),
        new JdeField("AQMCU", "AQMCU", JdeDataType.String, 24),
        new JdeField("AQQRCT", "AQQRCT", JdeDataType.String, 2),
        new JdeField("AQITLT", "AQITLT", JdeDataType.Numeric),
        new JdeField("AQDTO", "AQDTO", JdeDataType.String, 2),
        new JdeField("AQUOM", "AQUOM", JdeDataType.String, 4),
        new JdeField("AQSTUM", "AQSTUM", JdeDataType.Numeric),
        new JdeField("AQUNCS", "AQUNCS", JdeDataType.Numeric),
        new JdeField("AQECST", "AQECST", JdeDataType.Numeric),
        new JdeField("AQTRDJ", "AQTRDJ", JdeDataType.Numeric),
        new JdeField("AQDGL", "AQDGL", JdeDataType.Numeric),
        new JdeField("AQUKID", "AQUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("AQFILE", "AQFILE", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39121W_0", "Primary Key on AQUKID, AQFILE", new[] { "AQUKID", "AQFILE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39121W_1", "Index on AQITM, AQCO, AQMCU", new[] { "AQITM", "AQCO", "AQMCU" })
    };
}
