using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L109W - .
/// </summary>
public class F15L109W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GAMCU.
        /// </summary>
        public const string GAMCU = "GAMCU";

        /// <summary>
        /// GAASSD.
        /// </summary>
        public const string GAASSD = "GAASSD";

        /// <summary>
        /// GAASTP.
        /// </summary>
        public const string GAASTP = "GAASTP";

        /// <summary>
        /// GARVNB.
        /// </summary>
        public const string GARVNB = "GARVNB";

        /// <summary>
        /// GAGW01.
        /// </summary>
        public const string GAGW01 = "GAGW01";

        /// <summary>
        /// GAGW02.
        /// </summary>
        public const string GAGW02 = "GAGW02";

        /// <summary>
        /// GAGW03.
        /// </summary>
        public const string GAGW03 = "GAGW03";

        /// <summary>
        /// GAGW04.
        /// </summary>
        public const string GAGW04 = "GAGW04";

        /// <summary>
        /// GAGW05.
        /// </summary>
        public const string GAGW05 = "GAGW05";

        /// <summary>
        /// GAGW06.
        /// </summary>
        public const string GAGW06 = "GAGW06";

        /// <summary>
        /// GAGW07.
        /// </summary>
        public const string GAGW07 = "GAGW07";

        /// <summary>
        /// GAGW08.
        /// </summary>
        public const string GAGW08 = "GAGW08";

        /// <summary>
        /// GAGW09.
        /// </summary>
        public const string GAGW09 = "GAGW09";

        /// <summary>
        /// GAGW10.
        /// </summary>
        public const string GAGW10 = "GAGW10";

        /// <summary>
        /// GAGW11.
        /// </summary>
        public const string GAGW11 = "GAGW11";

        /// <summary>
        /// GAGW12.
        /// </summary>
        public const string GAGW12 = "GAGW12";

        /// <summary>
        /// GAGW13.
        /// </summary>
        public const string GAGW13 = "GAGW13";

        /// <summary>
        /// GAGW14.
        /// </summary>
        public const string GAGW14 = "GAGW14";

        /// <summary>
        /// GAGW15.
        /// </summary>
        public const string GAGW15 = "GAGW15";

        /// <summary>
        /// GAUSER.
        /// </summary>
        public const string GAUSER = "GAUSER";

        /// <summary>
        /// GAPID.
        /// </summary>
        public const string GAPID = "GAPID";

        /// <summary>
        /// GAJOBN.
        /// </summary>
        public const string GAJOBN = "GAJOBN";

        /// <summary>
        /// GAUPMJ.
        /// </summary>
        public const string GAUPMJ = "GAUPMJ";

        /// <summary>
        /// GAUPMT.
        /// </summary>
        public const string GAUPMT = "GAUPMT";

        /// <summary>
        /// GATORG.
        /// </summary>
        public const string GATORG = "GATORG";

        /// <summary>
        /// GAENTJ.
        /// </summary>
        public const string GAENTJ = "GAENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L109W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GAMCU", "GAMCU", JdeDataType.String, 24, true, true),
        new JdeField("GAASSD", "GAASSD", JdeDataType.String, 20, true, true),
        new JdeField("GAASTP", "GAASTP", JdeDataType.String, 4),
        new JdeField("GARVNB", "GARVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("GAGW01", "GAGW01", JdeDataType.Numeric),
        new JdeField("GAGW02", "GAGW02", JdeDataType.Numeric),
        new JdeField("GAGW03", "GAGW03", JdeDataType.Numeric),
        new JdeField("GAGW04", "GAGW04", JdeDataType.Numeric),
        new JdeField("GAGW05", "GAGW05", JdeDataType.Numeric),
        new JdeField("GAGW06", "GAGW06", JdeDataType.Numeric),
        new JdeField("GAGW07", "GAGW07", JdeDataType.Numeric),
        new JdeField("GAGW08", "GAGW08", JdeDataType.Numeric),
        new JdeField("GAGW09", "GAGW09", JdeDataType.Numeric),
        new JdeField("GAGW10", "GAGW10", JdeDataType.Numeric),
        new JdeField("GAGW11", "GAGW11", JdeDataType.Numeric),
        new JdeField("GAGW12", "GAGW12", JdeDataType.Numeric),
        new JdeField("GAGW13", "GAGW13", JdeDataType.Numeric),
        new JdeField("GAGW14", "GAGW14", JdeDataType.Numeric),
        new JdeField("GAGW15", "GAGW15", JdeDataType.Numeric),
        new JdeField("GAUSER", "GAUSER", JdeDataType.String, 20),
        new JdeField("GAPID", "GAPID", JdeDataType.String, 20),
        new JdeField("GAJOBN", "GAJOBN", JdeDataType.String, 20),
        new JdeField("GAUPMJ", "GAUPMJ", JdeDataType.Numeric),
        new JdeField("GAUPMT", "GAUPMT", JdeDataType.Numeric),
        new JdeField("GATORG", "GATORG", JdeDataType.String, 20),
        new JdeField("GAENTJ", "GAENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L109W_0", "Primary Key on GAMCU, GAASSD, GARVNB", new[] { "GAMCU", "GAASSD", "GARVNB" }, isUnique: true, isPrimaryKey: true)
    };
}
