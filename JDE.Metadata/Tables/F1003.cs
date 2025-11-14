using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1003 - .
/// </summary>
public class F1003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GREDBT.
        /// </summary>
        public const string GREDBT = "GREDBT";

        /// <summary>
        /// GREDUS.
        /// </summary>
        public const string GREDUS = "GREDUS";

        /// <summary>
        /// GREDTN.
        /// </summary>
        public const string GREDTN = "GREDTN";

        /// <summary>
        /// GRRC5.
        /// </summary>
        public const string GRRC5 = "GRRC5";

        /// <summary>
        /// GRTATP.
        /// </summary>
        public const string GRTATP = "GRTATP";

        /// <summary>
        /// GRMCU.
        /// </summary>
        public const string GRMCU = "GRMCU";

        /// <summary>
        /// GROBJ.
        /// </summary>
        public const string GROBJ = "GROBJ";

        /// <summary>
        /// GRSUB.
        /// </summary>
        public const string GRSUB = "GRSUB";

        /// <summary>
        /// GRRP01.
        /// </summary>
        public const string GRRP01 = "GRRP01";

        /// <summary>
        /// GRRP02.
        /// </summary>
        public const string GRRP02 = "GRRP02";

        /// <summary>
        /// GRRP03.
        /// </summary>
        public const string GRRP03 = "GRRP03";

        /// <summary>
        /// GRRP04.
        /// </summary>
        public const string GRRP04 = "GRRP04";

        /// <summary>
        /// GRRP05.
        /// </summary>
        public const string GRRP05 = "GRRP05";

        /// <summary>
        /// GRRP06.
        /// </summary>
        public const string GRRP06 = "GRRP06";

        /// <summary>
        /// GRRP07.
        /// </summary>
        public const string GRRP07 = "GRRP07";

        /// <summary>
        /// GRRP08.
        /// </summary>
        public const string GRRP08 = "GRRP08";

        /// <summary>
        /// GRRP09.
        /// </summary>
        public const string GRRP09 = "GRRP09";

        /// <summary>
        /// GRRP10.
        /// </summary>
        public const string GRRP10 = "GRRP10";

        /// <summary>
        /// GRRP11.
        /// </summary>
        public const string GRRP11 = "GRRP11";

        /// <summary>
        /// GRRP12.
        /// </summary>
        public const string GRRP12 = "GRRP12";

        /// <summary>
        /// GRRP13.
        /// </summary>
        public const string GRRP13 = "GRRP13";

        /// <summary>
        /// GRRP14.
        /// </summary>
        public const string GRRP14 = "GRRP14";

        /// <summary>
        /// GRRP15.
        /// </summary>
        public const string GRRP15 = "GRRP15";

        /// <summary>
        /// GRRP16.
        /// </summary>
        public const string GRRP16 = "GRRP16";

        /// <summary>
        /// GRRP17.
        /// </summary>
        public const string GRRP17 = "GRRP17";

        /// <summary>
        /// GRRP18.
        /// </summary>
        public const string GRRP18 = "GRRP18";

        /// <summary>
        /// GRRP19.
        /// </summary>
        public const string GRRP19 = "GRRP19";

        /// <summary>
        /// GRRP20.
        /// </summary>
        public const string GRRP20 = "GRRP20";

        /// <summary>
        /// GRRP21.
        /// </summary>
        public const string GRRP21 = "GRRP21";

        /// <summary>
        /// GRRP22.
        /// </summary>
        public const string GRRP22 = "GRRP22";

        /// <summary>
        /// GRRP23.
        /// </summary>
        public const string GRRP23 = "GRRP23";

        /// <summary>
        /// GRRP24.
        /// </summary>
        public const string GRRP24 = "GRRP24";

        /// <summary>
        /// GRRP25.
        /// </summary>
        public const string GRRP25 = "GRRP25";

        /// <summary>
        /// GRRP26.
        /// </summary>
        public const string GRRP26 = "GRRP26";

        /// <summary>
        /// GRRP27.
        /// </summary>
        public const string GRRP27 = "GRRP27";

        /// <summary>
        /// GRRP28.
        /// </summary>
        public const string GRRP28 = "GRRP28";

        /// <summary>
        /// GRRP29.
        /// </summary>
        public const string GRRP29 = "GRRP29";

        /// <summary>
        /// GRRP30.
        /// </summary>
        public const string GRRP30 = "GRRP30";

        /// <summary>
        /// GRRP31.
        /// </summary>
        public const string GRRP31 = "GRRP31";

        /// <summary>
        /// GRRP32.
        /// </summary>
        public const string GRRP32 = "GRRP32";

        /// <summary>
        /// GRRP33.
        /// </summary>
        public const string GRRP33 = "GRRP33";

        /// <summary>
        /// GRRP34.
        /// </summary>
        public const string GRRP34 = "GRRP34";

        /// <summary>
        /// GRRP35.
        /// </summary>
        public const string GRRP35 = "GRRP35";

        /// <summary>
        /// GRRP36.
        /// </summary>
        public const string GRRP36 = "GRRP36";

        /// <summary>
        /// GRRP37.
        /// </summary>
        public const string GRRP37 = "GRRP37";

        /// <summary>
        /// GRRP38.
        /// </summary>
        public const string GRRP38 = "GRRP38";

        /// <summary>
        /// GRRP39.
        /// </summary>
        public const string GRRP39 = "GRRP39";

        /// <summary>
        /// GRRP40.
        /// </summary>
        public const string GRRP40 = "GRRP40";

        /// <summary>
        /// GRRP41.
        /// </summary>
        public const string GRRP41 = "GRRP41";

        /// <summary>
        /// GRRP42.
        /// </summary>
        public const string GRRP42 = "GRRP42";

        /// <summary>
        /// GRRP43.
        /// </summary>
        public const string GRRP43 = "GRRP43";

        /// <summary>
        /// GRRP44.
        /// </summary>
        public const string GRRP44 = "GRRP44";

        /// <summary>
        /// GRRP45.
        /// </summary>
        public const string GRRP45 = "GRRP45";

        /// <summary>
        /// GRRP46.
        /// </summary>
        public const string GRRP46 = "GRRP46";

        /// <summary>
        /// GRRP47.
        /// </summary>
        public const string GRRP47 = "GRRP47";

        /// <summary>
        /// GRRP48.
        /// </summary>
        public const string GRRP48 = "GRRP48";

        /// <summary>
        /// GRRP49.
        /// </summary>
        public const string GRRP49 = "GRRP49";

        /// <summary>
        /// GRRP50.
        /// </summary>
        public const string GRRP50 = "GRRP50";
    }

    /// <inheritdoc />
    public override string TableName => "F1003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GREDBT", "GREDBT", JdeDataType.String, 30, true, true),
        new JdeField("GREDUS", "GREDUS", JdeDataType.String, 20, true, true),
        new JdeField("GREDTN", "GREDTN", JdeDataType.String, 44, true, true),
        new JdeField("GRRC5", "GRRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("GRTATP", "GRTATP", JdeDataType.String, 2),
        new JdeField("GRMCU", "GRMCU", JdeDataType.String, 24),
        new JdeField("GROBJ", "GROBJ", JdeDataType.String, 12),
        new JdeField("GRSUB", "GRSUB", JdeDataType.String, 16),
        new JdeField("GRRP01", "GRRP01", JdeDataType.String, 6),
        new JdeField("GRRP02", "GRRP02", JdeDataType.String, 6),
        new JdeField("GRRP03", "GRRP03", JdeDataType.String, 6),
        new JdeField("GRRP04", "GRRP04", JdeDataType.String, 6),
        new JdeField("GRRP05", "GRRP05", JdeDataType.String, 6),
        new JdeField("GRRP06", "GRRP06", JdeDataType.String, 6),
        new JdeField("GRRP07", "GRRP07", JdeDataType.String, 6),
        new JdeField("GRRP08", "GRRP08", JdeDataType.String, 6),
        new JdeField("GRRP09", "GRRP09", JdeDataType.String, 6),
        new JdeField("GRRP10", "GRRP10", JdeDataType.String, 6),
        new JdeField("GRRP11", "GRRP11", JdeDataType.String, 6),
        new JdeField("GRRP12", "GRRP12", JdeDataType.String, 6),
        new JdeField("GRRP13", "GRRP13", JdeDataType.String, 6),
        new JdeField("GRRP14", "GRRP14", JdeDataType.String, 6),
        new JdeField("GRRP15", "GRRP15", JdeDataType.String, 6),
        new JdeField("GRRP16", "GRRP16", JdeDataType.String, 6),
        new JdeField("GRRP17", "GRRP17", JdeDataType.String, 6),
        new JdeField("GRRP18", "GRRP18", JdeDataType.String, 6),
        new JdeField("GRRP19", "GRRP19", JdeDataType.String, 6),
        new JdeField("GRRP20", "GRRP20", JdeDataType.String, 6),
        new JdeField("GRRP21", "GRRP21", JdeDataType.String, 20),
        new JdeField("GRRP22", "GRRP22", JdeDataType.String, 20),
        new JdeField("GRRP23", "GRRP23", JdeDataType.String, 20),
        new JdeField("GRRP24", "GRRP24", JdeDataType.String, 20),
        new JdeField("GRRP25", "GRRP25", JdeDataType.String, 20),
        new JdeField("GRRP26", "GRRP26", JdeDataType.String, 20),
        new JdeField("GRRP27", "GRRP27", JdeDataType.String, 20),
        new JdeField("GRRP28", "GRRP28", JdeDataType.String, 20),
        new JdeField("GRRP29", "GRRP29", JdeDataType.String, 20),
        new JdeField("GRRP30", "GRRP30", JdeDataType.String, 20),
        new JdeField("GRRP31", "GRRP31", JdeDataType.String, 20),
        new JdeField("GRRP32", "GRRP32", JdeDataType.String, 20),
        new JdeField("GRRP33", "GRRP33", JdeDataType.String, 20),
        new JdeField("GRRP34", "GRRP34", JdeDataType.String, 20),
        new JdeField("GRRP35", "GRRP35", JdeDataType.String, 20),
        new JdeField("GRRP36", "GRRP36", JdeDataType.String, 20),
        new JdeField("GRRP37", "GRRP37", JdeDataType.String, 20),
        new JdeField("GRRP38", "GRRP38", JdeDataType.String, 20),
        new JdeField("GRRP39", "GRRP39", JdeDataType.String, 20),
        new JdeField("GRRP40", "GRRP40", JdeDataType.String, 20),
        new JdeField("GRRP41", "GRRP41", JdeDataType.String, 20),
        new JdeField("GRRP42", "GRRP42", JdeDataType.String, 20),
        new JdeField("GRRP43", "GRRP43", JdeDataType.String, 20),
        new JdeField("GRRP44", "GRRP44", JdeDataType.String, 20),
        new JdeField("GRRP45", "GRRP45", JdeDataType.String, 20),
        new JdeField("GRRP46", "GRRP46", JdeDataType.String, 20),
        new JdeField("GRRP47", "GRRP47", JdeDataType.String, 20),
        new JdeField("GRRP48", "GRRP48", JdeDataType.String, 20),
        new JdeField("GRRP49", "GRRP49", JdeDataType.String, 20),
        new JdeField("GRRP50", "GRRP50", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1003_0", "Primary Key on GREDBT, GREDUS, GREDTN, GRRC5", new[] { "GREDBT", "GREDUS", "GREDTN", "GRRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1003_2", "Index on GREDBT, GREDUS, GREDTN, GRTATP, GRMCU, GROBJ, GRSUB", new[] { "GREDBT", "GREDUS", "GREDTN", "GRTATP", "GRMCU", "GROBJ", "GRSUB" }),
        new JdeIndex("F1003_3", "Index on GRMCU, GROBJ, GRSUB", new[] { "GRMCU", "GROBJ", "GRSUB" })
    };
}
