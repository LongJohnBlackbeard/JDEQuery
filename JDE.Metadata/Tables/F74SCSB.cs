using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74SCSB - .
/// </summary>
public class F74SCSB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSSBCO.
        /// </summary>
        public const string CSSBCO = "CSSBCO";

        /// <summary>
        /// CSSOCO.
        /// </summary>
        public const string CSSOCO = "CSSOCO";

        /// <summary>
        /// CSSSNU.
        /// </summary>
        public const string CSSSNU = "CSSSNU";

        /// <summary>
        /// CSSBNA.
        /// </summary>
        public const string CSSBNA = "CSSBNA";

        /// <summary>
        /// CSSONA.
        /// </summary>
        public const string CSSONA = "CSSONA";

        /// <summary>
        /// CSSOAD.
        /// </summary>
        public const string CSSOAD = "CSSOAD";

        /// <summary>
        /// CSSCDI.
        /// </summary>
        public const string CSSCDI = "CSSCDI";

        /// <summary>
        /// CSSFI1.
        /// </summary>
        public const string CSSFI1 = "CSSFI1";

        /// <summary>
        /// CSSCNC.
        /// </summary>
        public const string CSSCNC = "CSSCNC";

        /// <summary>
        /// CSSCNL.
        /// </summary>
        public const string CSSCNL = "CSSCNL";

        /// <summary>
        /// CSSOFT.
        /// </summary>
        public const string CSSOFT = "CSSOFT";

        /// <summary>
        /// CSSBSI.
        /// </summary>
        public const string CSSBSI = "CSSBSI";

        /// <summary>
        /// CSSACO.
        /// </summary>
        public const string CSSACO = "CSSACO";

        /// <summary>
        /// CSSPNU.
        /// </summary>
        public const string CSSPNU = "CSSPNU";

        /// <summary>
        /// CSSENU.
        /// </summary>
        public const string CSSENU = "CSSENU";

        /// <summary>
        /// CSSTNU.
        /// </summary>
        public const string CSSTNU = "CSSTNU";

        /// <summary>
        /// CSSZCO.
        /// </summary>
        public const string CSSZCO = "CSSZCO";

        /// <summary>
        /// CSSFI2.
        /// </summary>
        public const string CSSFI2 = "CSSFI2";
    }

    /// <inheritdoc />
    public override string TableName => "F74SCSB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSSBCO", "CSSBCO", JdeDataType.String, 8, true, true),
        new JdeField("CSSOCO", "CSSOCO", JdeDataType.String, 8, true, true),
        new JdeField("CSSSNU", "CSSSNU", JdeDataType.String, 8),
        new JdeField("CSSBNA", "CSSBNA", JdeDataType.String, 72),
        new JdeField("CSSONA", "CSSONA", JdeDataType.String, 72),
        new JdeField("CSSOAD", "CSSOAD", JdeDataType.String, 80),
        new JdeField("CSSCDI", "CSSCDI", JdeDataType.String, 2),
        new JdeField("CSSFI1", "CSSFI1", JdeDataType.String, 2),
        new JdeField("CSSCNC", "CSSCNC", JdeDataType.String, 80),
        new JdeField("CSSCNL", "CSSCNL", JdeDataType.String, 80),
        new JdeField("CSSOFT", "CSSOFT", JdeDataType.String, 2),
        new JdeField("CSSBSI", "CSSBSI", JdeDataType.String, 18),
        new JdeField("CSSACO", "CSSACO", JdeDataType.String, 6),
        new JdeField("CSSPNU", "CSSPNU", JdeDataType.String, 14),
        new JdeField("CSSENU", "CSSENU", JdeDataType.String, 14),
        new JdeField("CSSTNU", "CSSTNU", JdeDataType.String, 14),
        new JdeField("CSSZCO", "CSSZCO", JdeDataType.Numeric),
        new JdeField("CSSFI2", "CSSFI2", JdeDataType.String, 34)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74SCSB_0", "Primary Key on CSSBCO, CSSOCO", new[] { "CSSBCO", "CSSOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74SCSB_2", "Index on CSSBNA, CSSONA", new[] { "CSSBNA", "CSSONA" })
    };
}
