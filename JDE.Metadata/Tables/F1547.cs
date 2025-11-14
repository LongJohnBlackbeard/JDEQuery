using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1547 - .
/// </summary>
public class F1547 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIMCUS.
        /// </summary>
        public const string OIMCUS = "OIMCUS";

        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OIULI.
        /// </summary>
        public const string OIULI = "OIULI";

        /// <summary>
        /// OICTRY.
        /// </summary>
        public const string OICTRY = "OICTRY";

        /// <summary>
        /// OIYR.
        /// </summary>
        public const string OIYR = "OIYR";

        /// <summary>
        /// OIDEFL.
        /// </summary>
        public const string OIDEFL = "OIDEFL";

        /// <summary>
        /// OIPRDC.
        /// </summary>
        public const string OIPRDC = "OIPRDC";

        /// <summary>
        /// OINUMTEN.
        /// </summary>
        public const string OINUMTEN = "OINUMTEN";

        /// <summary>
        /// OISN01.
        /// </summary>
        public const string OISN01 = "OISN01";

        /// <summary>
        /// OISN02.
        /// </summary>
        public const string OISN02 = "OISN02";

        /// <summary>
        /// OISN03.
        /// </summary>
        public const string OISN03 = "OISN03";

        /// <summary>
        /// OISN04.
        /// </summary>
        public const string OISN04 = "OISN04";

        /// <summary>
        /// OISN05.
        /// </summary>
        public const string OISN05 = "OISN05";

        /// <summary>
        /// OISN06.
        /// </summary>
        public const string OISN06 = "OISN06";

        /// <summary>
        /// OISN07.
        /// </summary>
        public const string OISN07 = "OISN07";

        /// <summary>
        /// OISN08.
        /// </summary>
        public const string OISN08 = "OISN08";

        /// <summary>
        /// OISN09.
        /// </summary>
        public const string OISN09 = "OISN09";

        /// <summary>
        /// OISN10.
        /// </summary>
        public const string OISN10 = "OISN10";

        /// <summary>
        /// OISN11.
        /// </summary>
        public const string OISN11 = "OISN11";

        /// <summary>
        /// OISN12.
        /// </summary>
        public const string OISN12 = "OISN12";

        /// <summary>
        /// OISNUF.
        /// </summary>
        public const string OISNUF = "OISNUF";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OIUPMT.
        /// </summary>
        public const string OIUPMT = "OIUPMT";

        /// <summary>
        /// OITORG.
        /// </summary>
        public const string OITORG = "OITORG";

        /// <summary>
        /// OIENTJ.
        /// </summary>
        public const string OIENTJ = "OIENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1547";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIMCUS", "OIMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24, true, true),
        new JdeField("OIULI", "OIULI", JdeDataType.String, 16, true, true),
        new JdeField("OICTRY", "OICTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OIYR", "OIYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDEFL", "OIDEFL", JdeDataType.String, 2, true, true),
        new JdeField("OIPRDC", "OIPRDC", JdeDataType.String, 8),
        new JdeField("OINUMTEN", "OINUMTEN", JdeDataType.Numeric),
        new JdeField("OISN01", "OISN01", JdeDataType.Numeric),
        new JdeField("OISN02", "OISN02", JdeDataType.Numeric),
        new JdeField("OISN03", "OISN03", JdeDataType.Numeric),
        new JdeField("OISN04", "OISN04", JdeDataType.Numeric),
        new JdeField("OISN05", "OISN05", JdeDataType.Numeric),
        new JdeField("OISN06", "OISN06", JdeDataType.Numeric),
        new JdeField("OISN07", "OISN07", JdeDataType.Numeric),
        new JdeField("OISN08", "OISN08", JdeDataType.Numeric),
        new JdeField("OISN09", "OISN09", JdeDataType.Numeric),
        new JdeField("OISN10", "OISN10", JdeDataType.Numeric),
        new JdeField("OISN11", "OISN11", JdeDataType.Numeric),
        new JdeField("OISN12", "OISN12", JdeDataType.Numeric),
        new JdeField("OISNUF", "OISNUF", JdeDataType.String, 2),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OIUPMT", "OIUPMT", JdeDataType.Numeric),
        new JdeField("OITORG", "OITORG", JdeDataType.String, 20),
        new JdeField("OIENTJ", "OIENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1547_0", "Primary Key on OIMCUS, OIMCU, OIULI, OICTRY, OIYR, OIDEFL", new[] { "OIMCUS", "OIMCU", "OIULI", "OICTRY", "OIYR", "OIDEFL" }, isUnique: true, isPrimaryKey: true)
    };
}
