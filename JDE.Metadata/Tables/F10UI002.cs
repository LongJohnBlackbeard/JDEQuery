using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI002 - .
/// </summary>
public class F10UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUEDUS.
        /// </summary>
        public const string BUEDUS = "BUEDUS";

        /// <summary>
        /// BUEDTN.
        /// </summary>
        public const string BUEDTN = "BUEDTN";

        /// <summary>
        /// BUEDBT.
        /// </summary>
        public const string BUEDBT = "BUEDBT";

        /// <summary>
        /// BUDTSE.
        /// </summary>
        public const string BUDTSE = "BUDTSE";

        /// <summary>
        /// BUMCU.
        /// </summary>
        public const string BUMCU = "BUMCU";

        /// <summary>
        /// BUDL01.
        /// </summary>
        public const string BUDL01 = "BUDL01";

        /// <summary>
        /// BUCO.
        /// </summary>
        public const string BUCO = "BUCO";

        /// <summary>
        /// BURP01.
        /// </summary>
        public const string BURP01 = "BURP01";

        /// <summary>
        /// BURP02.
        /// </summary>
        public const string BURP02 = "BURP02";

        /// <summary>
        /// BURP03.
        /// </summary>
        public const string BURP03 = "BURP03";

        /// <summary>
        /// BURP04.
        /// </summary>
        public const string BURP04 = "BURP04";

        /// <summary>
        /// BURP05.
        /// </summary>
        public const string BURP05 = "BURP05";

        /// <summary>
        /// BURP06.
        /// </summary>
        public const string BURP06 = "BURP06";

        /// <summary>
        /// BURP07.
        /// </summary>
        public const string BURP07 = "BURP07";

        /// <summary>
        /// BURP08.
        /// </summary>
        public const string BURP08 = "BURP08";

        /// <summary>
        /// BURP09.
        /// </summary>
        public const string BURP09 = "BURP09";

        /// <summary>
        /// BURP10.
        /// </summary>
        public const string BURP10 = "BURP10";

        /// <summary>
        /// BURP11.
        /// </summary>
        public const string BURP11 = "BURP11";

        /// <summary>
        /// BURP12.
        /// </summary>
        public const string BURP12 = "BURP12";

        /// <summary>
        /// BURP13.
        /// </summary>
        public const string BURP13 = "BURP13";

        /// <summary>
        /// BURP14.
        /// </summary>
        public const string BURP14 = "BURP14";

        /// <summary>
        /// BURP15.
        /// </summary>
        public const string BURP15 = "BURP15";

        /// <summary>
        /// BURP16.
        /// </summary>
        public const string BURP16 = "BURP16";

        /// <summary>
        /// BURP17.
        /// </summary>
        public const string BURP17 = "BURP17";

        /// <summary>
        /// BURP18.
        /// </summary>
        public const string BURP18 = "BURP18";

        /// <summary>
        /// BURP19.
        /// </summary>
        public const string BURP19 = "BURP19";

        /// <summary>
        /// BURP20.
        /// </summary>
        public const string BURP20 = "BURP20";

        /// <summary>
        /// BURP21.
        /// </summary>
        public const string BURP21 = "BURP21";

        /// <summary>
        /// BURP22.
        /// </summary>
        public const string BURP22 = "BURP22";

        /// <summary>
        /// BURP23.
        /// </summary>
        public const string BURP23 = "BURP23";

        /// <summary>
        /// BURP24.
        /// </summary>
        public const string BURP24 = "BURP24";

        /// <summary>
        /// BURP25.
        /// </summary>
        public const string BURP25 = "BURP25";

        /// <summary>
        /// BURP26.
        /// </summary>
        public const string BURP26 = "BURP26";

        /// <summary>
        /// BURP27.
        /// </summary>
        public const string BURP27 = "BURP27";

        /// <summary>
        /// BURP28.
        /// </summary>
        public const string BURP28 = "BURP28";

        /// <summary>
        /// BURP29.
        /// </summary>
        public const string BURP29 = "BURP29";

        /// <summary>
        /// BURP30.
        /// </summary>
        public const string BURP30 = "BURP30";

        /// <summary>
        /// BUPID.
        /// </summary>
        public const string BUPID = "BUPID";

        /// <summary>
        /// BURP31.
        /// </summary>
        public const string BURP31 = "BURP31";

        /// <summary>
        /// BURP32.
        /// </summary>
        public const string BURP32 = "BURP32";

        /// <summary>
        /// BURP33.
        /// </summary>
        public const string BURP33 = "BURP33";

        /// <summary>
        /// BURP34.
        /// </summary>
        public const string BURP34 = "BURP34";

        /// <summary>
        /// BURP35.
        /// </summary>
        public const string BURP35 = "BURP35";

        /// <summary>
        /// BURP36.
        /// </summary>
        public const string BURP36 = "BURP36";

        /// <summary>
        /// BURP37.
        /// </summary>
        public const string BURP37 = "BURP37";

        /// <summary>
        /// BURP38.
        /// </summary>
        public const string BURP38 = "BURP38";

        /// <summary>
        /// BURP39.
        /// </summary>
        public const string BURP39 = "BURP39";

        /// <summary>
        /// BURP40.
        /// </summary>
        public const string BURP40 = "BURP40";

        /// <summary>
        /// BURP41.
        /// </summary>
        public const string BURP41 = "BURP41";

        /// <summary>
        /// BURP42.
        /// </summary>
        public const string BURP42 = "BURP42";

        /// <summary>
        /// BURP43.
        /// </summary>
        public const string BURP43 = "BURP43";

        /// <summary>
        /// BURP44.
        /// </summary>
        public const string BURP44 = "BURP44";

        /// <summary>
        /// BURP45.
        /// </summary>
        public const string BURP45 = "BURP45";

        /// <summary>
        /// BURP46.
        /// </summary>
        public const string BURP46 = "BURP46";

        /// <summary>
        /// BURP47.
        /// </summary>
        public const string BURP47 = "BURP47";

        /// <summary>
        /// BURP48.
        /// </summary>
        public const string BURP48 = "BURP48";

        /// <summary>
        /// BURP49.
        /// </summary>
        public const string BURP49 = "BURP49";

        /// <summary>
        /// BURP50.
        /// </summary>
        public const string BURP50 = "BURP50";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUEDUS", "BUEDUS", JdeDataType.String, 20),
        new JdeField("BUEDTN", "BUEDTN", JdeDataType.String, 44),
        new JdeField("BUEDBT", "BUEDBT", JdeDataType.String, 30),
        new JdeField("BUDTSE", "BUDTSE", JdeDataType.Numeric),
        new JdeField("BUMCU", "BUMCU", JdeDataType.String, 24, true, true),
        new JdeField("BUDL01", "BUDL01", JdeDataType.String, 60),
        new JdeField("BUCO", "BUCO", JdeDataType.String, 10),
        new JdeField("BURP01", "BURP01", JdeDataType.String, 6),
        new JdeField("BURP02", "BURP02", JdeDataType.String, 6),
        new JdeField("BURP03", "BURP03", JdeDataType.String, 6),
        new JdeField("BURP04", "BURP04", JdeDataType.String, 6),
        new JdeField("BURP05", "BURP05", JdeDataType.String, 6),
        new JdeField("BURP06", "BURP06", JdeDataType.String, 6),
        new JdeField("BURP07", "BURP07", JdeDataType.String, 6),
        new JdeField("BURP08", "BURP08", JdeDataType.String, 6),
        new JdeField("BURP09", "BURP09", JdeDataType.String, 6),
        new JdeField("BURP10", "BURP10", JdeDataType.String, 6),
        new JdeField("BURP11", "BURP11", JdeDataType.String, 6),
        new JdeField("BURP12", "BURP12", JdeDataType.String, 6),
        new JdeField("BURP13", "BURP13", JdeDataType.String, 6),
        new JdeField("BURP14", "BURP14", JdeDataType.String, 6),
        new JdeField("BURP15", "BURP15", JdeDataType.String, 6),
        new JdeField("BURP16", "BURP16", JdeDataType.String, 6),
        new JdeField("BURP17", "BURP17", JdeDataType.String, 6),
        new JdeField("BURP18", "BURP18", JdeDataType.String, 6),
        new JdeField("BURP19", "BURP19", JdeDataType.String, 6),
        new JdeField("BURP20", "BURP20", JdeDataType.String, 6),
        new JdeField("BURP21", "BURP21", JdeDataType.String, 20),
        new JdeField("BURP22", "BURP22", JdeDataType.String, 20),
        new JdeField("BURP23", "BURP23", JdeDataType.String, 20),
        new JdeField("BURP24", "BURP24", JdeDataType.String, 20),
        new JdeField("BURP25", "BURP25", JdeDataType.String, 20),
        new JdeField("BURP26", "BURP26", JdeDataType.String, 20),
        new JdeField("BURP27", "BURP27", JdeDataType.String, 20),
        new JdeField("BURP28", "BURP28", JdeDataType.String, 20),
        new JdeField("BURP29", "BURP29", JdeDataType.String, 20),
        new JdeField("BURP30", "BURP30", JdeDataType.String, 20),
        new JdeField("BUPID", "BUPID", JdeDataType.String, 20),
        new JdeField("BURP31", "BURP31", JdeDataType.String, 20),
        new JdeField("BURP32", "BURP32", JdeDataType.String, 20),
        new JdeField("BURP33", "BURP33", JdeDataType.String, 20),
        new JdeField("BURP34", "BURP34", JdeDataType.String, 20),
        new JdeField("BURP35", "BURP35", JdeDataType.String, 20),
        new JdeField("BURP36", "BURP36", JdeDataType.String, 20),
        new JdeField("BURP37", "BURP37", JdeDataType.String, 20),
        new JdeField("BURP38", "BURP38", JdeDataType.String, 20),
        new JdeField("BURP39", "BURP39", JdeDataType.String, 20),
        new JdeField("BURP40", "BURP40", JdeDataType.String, 20),
        new JdeField("BURP41", "BURP41", JdeDataType.String, 20),
        new JdeField("BURP42", "BURP42", JdeDataType.String, 20),
        new JdeField("BURP43", "BURP43", JdeDataType.String, 20),
        new JdeField("BURP44", "BURP44", JdeDataType.String, 20),
        new JdeField("BURP45", "BURP45", JdeDataType.String, 20),
        new JdeField("BURP46", "BURP46", JdeDataType.String, 20),
        new JdeField("BURP47", "BURP47", JdeDataType.String, 20),
        new JdeField("BURP48", "BURP48", JdeDataType.String, 20),
        new JdeField("BURP49", "BURP49", JdeDataType.String, 20),
        new JdeField("BURP50", "BURP50", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI002_0", "Primary Key on BUMCU", new[] { "BUMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10UI002_2", "Index on BUPID", new[] { "BUPID" })
    };
}
