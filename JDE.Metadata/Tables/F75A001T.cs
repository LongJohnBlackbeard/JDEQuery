using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A001T - .
/// </summary>
public class F75A001T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZAEDTF.
        /// </summary>
        public const string ZAEDTF = "ZAEDTF";

        /// <summary>
        /// ZAEDTT.
        /// </summary>
        public const string ZAEDTT = "ZAEDTT";

        /// <summary>
        /// ZACCPR.
        /// </summary>
        public const string ZACCPR = "ZACCPR";

        /// <summary>
        /// ZASCALE.
        /// </summary>
        public const string ZASCALE = "ZASCALE";

        /// <summary>
        /// ZALIMIT09.
        /// </summary>
        public const string ZALIMIT09 = "ZALIMIT09";

        /// <summary>
        /// ZALIMIT10.
        /// </summary>
        public const string ZALIMIT10 = "ZALIMIT10";

        /// <summary>
        /// ZALIMIT11.
        /// </summary>
        public const string ZALIMIT11 = "ZALIMIT11";

        /// <summary>
        /// ZALIMIT12.
        /// </summary>
        public const string ZALIMIT12 = "ZALIMIT12";

        /// <summary>
        /// ZALIMIT13.
        /// </summary>
        public const string ZALIMIT13 = "ZALIMIT13";

        /// <summary>
        /// ZALIMIT14.
        /// </summary>
        public const string ZALIMIT14 = "ZALIMIT14";

        /// <summary>
        /// ZALIMIT15.
        /// </summary>
        public const string ZALIMIT15 = "ZALIMIT15";

        /// <summary>
        /// ZALIMIT16.
        /// </summary>
        public const string ZALIMIT16 = "ZALIMIT16";

        /// <summary>
        /// ZALIMIT17.
        /// </summary>
        public const string ZALIMIT17 = "ZALIMIT17";

        /// <summary>
        /// ZALIMIT18.
        /// </summary>
        public const string ZALIMIT18 = "ZALIMIT18";

        /// <summary>
        /// ZALIMIT19.
        /// </summary>
        public const string ZALIMIT19 = "ZALIMIT19";

        /// <summary>
        /// ZALIMIT20.
        /// </summary>
        public const string ZALIMIT20 = "ZALIMIT20";

        /// <summary>
        /// ZALIMIT21.
        /// </summary>
        public const string ZALIMIT21 = "ZALIMIT21";

        /// <summary>
        /// ZALIMIT22.
        /// </summary>
        public const string ZALIMIT22 = "ZALIMIT22";

        /// <summary>
        /// ZALIMIT23.
        /// </summary>
        public const string ZALIMIT23 = "ZALIMIT23";

        /// <summary>
        /// ZALIMIT24.
        /// </summary>
        public const string ZALIMIT24 = "ZALIMIT24";

        /// <summary>
        /// ZALIMIT25.
        /// </summary>
        public const string ZALIMIT25 = "ZALIMIT25";

        /// <summary>
        /// ZALIMIT26.
        /// </summary>
        public const string ZALIMIT26 = "ZALIMIT26";

        /// <summary>
        /// ZALIMIT27.
        /// </summary>
        public const string ZALIMIT27 = "ZALIMIT27";

        /// <summary>
        /// ZALIMIT28.
        /// </summary>
        public const string ZALIMIT28 = "ZALIMIT28";

        /// <summary>
        /// ZALIMIT29.
        /// </summary>
        public const string ZALIMIT29 = "ZALIMIT29";

        /// <summary>
        /// ZALIMIT30.
        /// </summary>
        public const string ZALIMIT30 = "ZALIMIT30";

        /// <summary>
        /// ZALIMIT31.
        /// </summary>
        public const string ZALIMIT31 = "ZALIMIT31";

        /// <summary>
        /// ZALIMIT32.
        /// </summary>
        public const string ZALIMIT32 = "ZALIMIT32";

        /// <summary>
        /// ZATRATE09.
        /// </summary>
        public const string ZATRATE09 = "ZATRATE09";

        /// <summary>
        /// ZATRATE10.
        /// </summary>
        public const string ZATRATE10 = "ZATRATE10";

        /// <summary>
        /// ZATRATE11.
        /// </summary>
        public const string ZATRATE11 = "ZATRATE11";

        /// <summary>
        /// ZATRATE12.
        /// </summary>
        public const string ZATRATE12 = "ZATRATE12";

        /// <summary>
        /// ZATRATE13.
        /// </summary>
        public const string ZATRATE13 = "ZATRATE13";

        /// <summary>
        /// ZATRATE14.
        /// </summary>
        public const string ZATRATE14 = "ZATRATE14";

        /// <summary>
        /// ZATRATE15.
        /// </summary>
        public const string ZATRATE15 = "ZATRATE15";

        /// <summary>
        /// ZATRATE16.
        /// </summary>
        public const string ZATRATE16 = "ZATRATE16";

        /// <summary>
        /// ZATRATE17.
        /// </summary>
        public const string ZATRATE17 = "ZATRATE17";

        /// <summary>
        /// ZATRATE18.
        /// </summary>
        public const string ZATRATE18 = "ZATRATE18";

        /// <summary>
        /// ZATRATE19.
        /// </summary>
        public const string ZATRATE19 = "ZATRATE19";

        /// <summary>
        /// ZATRATE20.
        /// </summary>
        public const string ZATRATE20 = "ZATRATE20";

        /// <summary>
        /// ZATRATE21.
        /// </summary>
        public const string ZATRATE21 = "ZATRATE21";

        /// <summary>
        /// ZATRATE22.
        /// </summary>
        public const string ZATRATE22 = "ZATRATE22";

        /// <summary>
        /// ZATRATE23.
        /// </summary>
        public const string ZATRATE23 = "ZATRATE23";

        /// <summary>
        /// ZATRATE24.
        /// </summary>
        public const string ZATRATE24 = "ZATRATE24";

        /// <summary>
        /// ZATRATE25.
        /// </summary>
        public const string ZATRATE25 = "ZATRATE25";

        /// <summary>
        /// ZATRATE26.
        /// </summary>
        public const string ZATRATE26 = "ZATRATE26";

        /// <summary>
        /// ZATRATE27.
        /// </summary>
        public const string ZATRATE27 = "ZATRATE27";

        /// <summary>
        /// ZATRATE28.
        /// </summary>
        public const string ZATRATE28 = "ZATRATE28";

        /// <summary>
        /// ZATRATE29.
        /// </summary>
        public const string ZATRATE29 = "ZATRATE29";

        /// <summary>
        /// ZATRATE30.
        /// </summary>
        public const string ZATRATE30 = "ZATRATE30";

        /// <summary>
        /// ZATRATE31.
        /// </summary>
        public const string ZATRATE31 = "ZATRATE31";

        /// <summary>
        /// ZATRATE32.
        /// </summary>
        public const string ZATRATE32 = "ZATRATE32";

        /// <summary>
        /// ZAADJUST09.
        /// </summary>
        public const string ZAADJUST09 = "ZAADJUST09";

        /// <summary>
        /// ZAADJUST10.
        /// </summary>
        public const string ZAADJUST10 = "ZAADJUST10";

        /// <summary>
        /// ZAADJUST11.
        /// </summary>
        public const string ZAADJUST11 = "ZAADJUST11";

        /// <summary>
        /// ZAADJUST12.
        /// </summary>
        public const string ZAADJUST12 = "ZAADJUST12";

        /// <summary>
        /// ZAADJUST13.
        /// </summary>
        public const string ZAADJUST13 = "ZAADJUST13";

        /// <summary>
        /// ZAADJUST14.
        /// </summary>
        public const string ZAADJUST14 = "ZAADJUST14";

        /// <summary>
        /// ZAADJUST15.
        /// </summary>
        public const string ZAADJUST15 = "ZAADJUST15";

        /// <summary>
        /// ZAADJUST16.
        /// </summary>
        public const string ZAADJUST16 = "ZAADJUST16";

        /// <summary>
        /// ZAADJUST17.
        /// </summary>
        public const string ZAADJUST17 = "ZAADJUST17";

        /// <summary>
        /// ZAADJUST18.
        /// </summary>
        public const string ZAADJUST18 = "ZAADJUST18";

        /// <summary>
        /// ZAADJUST19.
        /// </summary>
        public const string ZAADJUST19 = "ZAADJUST19";

        /// <summary>
        /// ZAADJUST20.
        /// </summary>
        public const string ZAADJUST20 = "ZAADJUST20";

        /// <summary>
        /// ZAADJUST21.
        /// </summary>
        public const string ZAADJUST21 = "ZAADJUST21";

        /// <summary>
        /// ZAADJUST22.
        /// </summary>
        public const string ZAADJUST22 = "ZAADJUST22";

        /// <summary>
        /// ZAADJUST23.
        /// </summary>
        public const string ZAADJUST23 = "ZAADJUST23";

        /// <summary>
        /// ZAADJUST24.
        /// </summary>
        public const string ZAADJUST24 = "ZAADJUST24";

        /// <summary>
        /// ZAADJUST25.
        /// </summary>
        public const string ZAADJUST25 = "ZAADJUST25";

        /// <summary>
        /// ZAADJUST26.
        /// </summary>
        public const string ZAADJUST26 = "ZAADJUST26";

        /// <summary>
        /// ZAADJUST27.
        /// </summary>
        public const string ZAADJUST27 = "ZAADJUST27";

        /// <summary>
        /// ZAADJUST28.
        /// </summary>
        public const string ZAADJUST28 = "ZAADJUST28";

        /// <summary>
        /// ZAADJUST29.
        /// </summary>
        public const string ZAADJUST29 = "ZAADJUST29";

        /// <summary>
        /// ZAADJUST30.
        /// </summary>
        public const string ZAADJUST30 = "ZAADJUST30";

        /// <summary>
        /// ZAADJUST31.
        /// </summary>
        public const string ZAADJUST31 = "ZAADJUST31";

        /// <summary>
        /// ZAADJUST32.
        /// </summary>
        public const string ZAADJUST32 = "ZAADJUST32";

        /// <summary>
        /// ZAUPMJ.
        /// </summary>
        public const string ZAUPMJ = "ZAUPMJ";

        /// <summary>
        /// ZAUPMT.
        /// </summary>
        public const string ZAUPMT = "ZAUPMT";

        /// <summary>
        /// ZAPID.
        /// </summary>
        public const string ZAPID = "ZAPID";

        /// <summary>
        /// ZAJOBN.
        /// </summary>
        public const string ZAJOBN = "ZAJOBN";

        /// <summary>
        /// ZAUSER.
        /// </summary>
        public const string ZAUSER = "ZAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A001T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZAEDTF", "ZAEDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAEDTT", "ZAEDTT", JdeDataType.Numeric),
        new JdeField("ZACCPR", "ZACCPR", JdeDataType.String, 6),
        new JdeField("ZASCALE", "ZASCALE", JdeDataType.String, 6, true, true),
        new JdeField("ZALIMIT09", "ZALIMIT09", JdeDataType.Numeric),
        new JdeField("ZALIMIT10", "ZALIMIT10", JdeDataType.Numeric),
        new JdeField("ZALIMIT11", "ZALIMIT11", JdeDataType.Numeric),
        new JdeField("ZALIMIT12", "ZALIMIT12", JdeDataType.Numeric),
        new JdeField("ZALIMIT13", "ZALIMIT13", JdeDataType.Numeric),
        new JdeField("ZALIMIT14", "ZALIMIT14", JdeDataType.Numeric),
        new JdeField("ZALIMIT15", "ZALIMIT15", JdeDataType.Numeric),
        new JdeField("ZALIMIT16", "ZALIMIT16", JdeDataType.Numeric),
        new JdeField("ZALIMIT17", "ZALIMIT17", JdeDataType.Numeric),
        new JdeField("ZALIMIT18", "ZALIMIT18", JdeDataType.Numeric),
        new JdeField("ZALIMIT19", "ZALIMIT19", JdeDataType.Numeric),
        new JdeField("ZALIMIT20", "ZALIMIT20", JdeDataType.Numeric),
        new JdeField("ZALIMIT21", "ZALIMIT21", JdeDataType.Numeric),
        new JdeField("ZALIMIT22", "ZALIMIT22", JdeDataType.Numeric),
        new JdeField("ZALIMIT23", "ZALIMIT23", JdeDataType.Numeric),
        new JdeField("ZALIMIT24", "ZALIMIT24", JdeDataType.Numeric),
        new JdeField("ZALIMIT25", "ZALIMIT25", JdeDataType.Numeric),
        new JdeField("ZALIMIT26", "ZALIMIT26", JdeDataType.Numeric),
        new JdeField("ZALIMIT27", "ZALIMIT27", JdeDataType.Numeric),
        new JdeField("ZALIMIT28", "ZALIMIT28", JdeDataType.Numeric),
        new JdeField("ZALIMIT29", "ZALIMIT29", JdeDataType.Numeric),
        new JdeField("ZALIMIT30", "ZALIMIT30", JdeDataType.Numeric),
        new JdeField("ZALIMIT31", "ZALIMIT31", JdeDataType.Numeric),
        new JdeField("ZALIMIT32", "ZALIMIT32", JdeDataType.Numeric),
        new JdeField("ZATRATE09", "ZATRATE09", JdeDataType.Numeric),
        new JdeField("ZATRATE10", "ZATRATE10", JdeDataType.Numeric),
        new JdeField("ZATRATE11", "ZATRATE11", JdeDataType.Numeric),
        new JdeField("ZATRATE12", "ZATRATE12", JdeDataType.Numeric),
        new JdeField("ZATRATE13", "ZATRATE13", JdeDataType.Numeric),
        new JdeField("ZATRATE14", "ZATRATE14", JdeDataType.Numeric),
        new JdeField("ZATRATE15", "ZATRATE15", JdeDataType.Numeric),
        new JdeField("ZATRATE16", "ZATRATE16", JdeDataType.Numeric),
        new JdeField("ZATRATE17", "ZATRATE17", JdeDataType.Numeric),
        new JdeField("ZATRATE18", "ZATRATE18", JdeDataType.Numeric),
        new JdeField("ZATRATE19", "ZATRATE19", JdeDataType.Numeric),
        new JdeField("ZATRATE20", "ZATRATE20", JdeDataType.Numeric),
        new JdeField("ZATRATE21", "ZATRATE21", JdeDataType.Numeric),
        new JdeField("ZATRATE22", "ZATRATE22", JdeDataType.Numeric),
        new JdeField("ZATRATE23", "ZATRATE23", JdeDataType.Numeric),
        new JdeField("ZATRATE24", "ZATRATE24", JdeDataType.Numeric),
        new JdeField("ZATRATE25", "ZATRATE25", JdeDataType.Numeric),
        new JdeField("ZATRATE26", "ZATRATE26", JdeDataType.Numeric),
        new JdeField("ZATRATE27", "ZATRATE27", JdeDataType.Numeric),
        new JdeField("ZATRATE28", "ZATRATE28", JdeDataType.Numeric),
        new JdeField("ZATRATE29", "ZATRATE29", JdeDataType.Numeric),
        new JdeField("ZATRATE30", "ZATRATE30", JdeDataType.Numeric),
        new JdeField("ZATRATE31", "ZATRATE31", JdeDataType.Numeric),
        new JdeField("ZATRATE32", "ZATRATE32", JdeDataType.Numeric),
        new JdeField("ZAADJUST09", "ZAADJUST09", JdeDataType.Numeric),
        new JdeField("ZAADJUST10", "ZAADJUST10", JdeDataType.Numeric),
        new JdeField("ZAADJUST11", "ZAADJUST11", JdeDataType.Numeric),
        new JdeField("ZAADJUST12", "ZAADJUST12", JdeDataType.Numeric),
        new JdeField("ZAADJUST13", "ZAADJUST13", JdeDataType.Numeric),
        new JdeField("ZAADJUST14", "ZAADJUST14", JdeDataType.Numeric),
        new JdeField("ZAADJUST15", "ZAADJUST15", JdeDataType.Numeric),
        new JdeField("ZAADJUST16", "ZAADJUST16", JdeDataType.Numeric),
        new JdeField("ZAADJUST17", "ZAADJUST17", JdeDataType.Numeric),
        new JdeField("ZAADJUST18", "ZAADJUST18", JdeDataType.Numeric),
        new JdeField("ZAADJUST19", "ZAADJUST19", JdeDataType.Numeric),
        new JdeField("ZAADJUST20", "ZAADJUST20", JdeDataType.Numeric),
        new JdeField("ZAADJUST21", "ZAADJUST21", JdeDataType.Numeric),
        new JdeField("ZAADJUST22", "ZAADJUST22", JdeDataType.Numeric),
        new JdeField("ZAADJUST23", "ZAADJUST23", JdeDataType.Numeric),
        new JdeField("ZAADJUST24", "ZAADJUST24", JdeDataType.Numeric),
        new JdeField("ZAADJUST25", "ZAADJUST25", JdeDataType.Numeric),
        new JdeField("ZAADJUST26", "ZAADJUST26", JdeDataType.Numeric),
        new JdeField("ZAADJUST27", "ZAADJUST27", JdeDataType.Numeric),
        new JdeField("ZAADJUST28", "ZAADJUST28", JdeDataType.Numeric),
        new JdeField("ZAADJUST29", "ZAADJUST29", JdeDataType.Numeric),
        new JdeField("ZAADJUST30", "ZAADJUST30", JdeDataType.Numeric),
        new JdeField("ZAADJUST31", "ZAADJUST31", JdeDataType.Numeric),
        new JdeField("ZAADJUST32", "ZAADJUST32", JdeDataType.Numeric),
        new JdeField("ZAUPMJ", "ZAUPMJ", JdeDataType.Numeric),
        new JdeField("ZAUPMT", "ZAUPMT", JdeDataType.Numeric),
        new JdeField("ZAPID", "ZAPID", JdeDataType.String, 20),
        new JdeField("ZAJOBN", "ZAJOBN", JdeDataType.String, 20),
        new JdeField("ZAUSER", "ZAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A001T_0", "Primary Key on ZAEDTF, ZASCALE", new[] { "ZAEDTF", "ZASCALE" }, isUnique: true, isPrimaryKey: true)
    };
}
