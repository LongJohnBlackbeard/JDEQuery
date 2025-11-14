using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05850 - .
/// </summary>
public class F05850 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EOEEOCO.
        /// </summary>
        public const string EOEEOCO = "EOEEOCO";

        /// <summary>
        /// EOEEOUNT.
        /// </summary>
        public const string EOEEOUNT = "EOEEOUNT";

        /// <summary>
        /// EOCENTYR.
        /// </summary>
        public const string EOCENTYR = "EOCENTYR";

        /// <summary>
        /// EOAN8.
        /// </summary>
        public const string EOAN8 = "EOAN8";

        /// <summary>
        /// EOSIC.
        /// </summary>
        public const string EOSIC = "EOSIC";

        /// <summary>
        /// EOCO.
        /// </summary>
        public const string EOCO = "EOCO";

        /// <summary>
        /// EOEEMW.
        /// </summary>
        public const string EOEEMW = "EOEEMW";

        /// <summary>
        /// EOEEMB.
        /// </summary>
        public const string EOEEMB = "EOEEMB";

        /// <summary>
        /// EOEEMH.
        /// </summary>
        public const string EOEEMH = "EOEEMH";

        /// <summary>
        /// EOEEMA.
        /// </summary>
        public const string EOEEMA = "EOEEMA";

        /// <summary>
        /// EOEEMI.
        /// </summary>
        public const string EOEEMI = "EOEEMI";

        /// <summary>
        /// EOEEFW.
        /// </summary>
        public const string EOEEFW = "EOEEFW";

        /// <summary>
        /// EOEEFB.
        /// </summary>
        public const string EOEEFB = "EOEEFB";

        /// <summary>
        /// EOEEFH.
        /// </summary>
        public const string EOEEFH = "EOEEFH";

        /// <summary>
        /// EOEEFA.
        /// </summary>
        public const string EOEEFA = "EOEEFA";

        /// <summary>
        /// EOEEFI.
        /// </summary>
        public const string EOEEFI = "EOEEFI";

        /// <summary>
        /// EOEEMP.
        /// </summary>
        public const string EOEEMP = "EOEEMP";

        /// <summary>
        /// EOEEFP.
        /// </summary>
        public const string EOEEFP = "EOEEFP";

        /// <summary>
        /// EOEEM2.
        /// </summary>
        public const string EOEEM2 = "EOEEM2";

        /// <summary>
        /// EOEEF2.
        /// </summary>
        public const string EOEEF2 = "EOEEF2";

        /// <summary>
        /// EOJOBN.
        /// </summary>
        public const string EOJOBN = "EOJOBN";

        /// <summary>
        /// EOUSER.
        /// </summary>
        public const string EOUSER = "EOUSER";

        /// <summary>
        /// EOPID.
        /// </summary>
        public const string EOPID = "EOPID";

        /// <summary>
        /// EOUPMJ.
        /// </summary>
        public const string EOUPMJ = "EOUPMJ";

        /// <summary>
        /// EOTDAY.
        /// </summary>
        public const string EOTDAY = "EOTDAY";

        /// <summary>
        /// EOEEOJ.
        /// </summary>
        public const string EOEEOJ = "EOEEOJ";

        /// <summary>
        /// EOEEPB.
        /// </summary>
        public const string EOEEPB = "EOEEPB";

        /// <summary>
        /// EOEEMWH.
        /// </summary>
        public const string EOEEMWH = "EOEEMWH";

        /// <summary>
        /// EOEEMBH.
        /// </summary>
        public const string EOEEMBH = "EOEEMBH";

        /// <summary>
        /// EOEEMHH.
        /// </summary>
        public const string EOEEMHH = "EOEEMHH";

        /// <summary>
        /// EOEEMAH.
        /// </summary>
        public const string EOEEMAH = "EOEEMAH";

        /// <summary>
        /// EOEEMIH.
        /// </summary>
        public const string EOEEMIH = "EOEEMIH";

        /// <summary>
        /// EOEEFWH.
        /// </summary>
        public const string EOEEFWH = "EOEEFWH";

        /// <summary>
        /// EOEEFBH.
        /// </summary>
        public const string EOEEFBH = "EOEEFBH";

        /// <summary>
        /// EOEEFHH.
        /// </summary>
        public const string EOEEFHH = "EOEEFHH";

        /// <summary>
        /// EOEEFAH.
        /// </summary>
        public const string EOEEFAH = "EOEEFAH";

        /// <summary>
        /// EOEEFIH.
        /// </summary>
        public const string EOEEFIH = "EOEEFIH";

        /// <summary>
        /// EOEEMPH.
        /// </summary>
        public const string EOEEMPH = "EOEEMPH";

        /// <summary>
        /// EOEEFPH.
        /// </summary>
        public const string EOEEFPH = "EOEEFPH";

        /// <summary>
        /// EOEEM2H.
        /// </summary>
        public const string EOEEM2H = "EOEEM2H";

        /// <summary>
        /// EOEEF2H.
        /// </summary>
        public const string EOEEF2H = "EOEEF2H";

        /// <summary>
        /// EOEEO1SPS1.
        /// </summary>
        public const string EOEEO1SPS1 = "EOEEO1SPS1";

        /// <summary>
        /// EOEEO1SPS2.
        /// </summary>
        public const string EOEEO1SPS2 = "EOEEO1SPS2";

        /// <summary>
        /// EOEEO1SPS3.
        /// </summary>
        public const string EOEEO1SPS3 = "EOEEO1SPS3";

        /// <summary>
        /// EOEEO1SPS4.
        /// </summary>
        public const string EOEEO1SPS4 = "EOEEO1SPS4";

        /// <summary>
        /// EOEEO1SPN1.
        /// </summary>
        public const string EOEEO1SPN1 = "EOEEO1SPN1";

        /// <summary>
        /// EOEEO1SPN2.
        /// </summary>
        public const string EOEEO1SPN2 = "EOEEO1SPN2";

        /// <summary>
        /// EOEEO1SPN3.
        /// </summary>
        public const string EOEEO1SPN3 = "EOEEO1SPN3";

        /// <summary>
        /// EOEEO1SPN4.
        /// </summary>
        public const string EOEEO1SPN4 = "EOEEO1SPN4";

        /// <summary>
        /// EOEEO1SPC1.
        /// </summary>
        public const string EOEEO1SPC1 = "EOEEO1SPC1";

        /// <summary>
        /// EOEEO1SPC2.
        /// </summary>
        public const string EOEEO1SPC2 = "EOEEO1SPC2";

        /// <summary>
        /// EOEEO1SPC3.
        /// </summary>
        public const string EOEEO1SPC3 = "EOEEO1SPC3";

        /// <summary>
        /// EOEEO1SPC4.
        /// </summary>
        public const string EOEEO1SPC4 = "EOEEO1SPC4";

        /// <summary>
        /// EOEEO1SPD1.
        /// </summary>
        public const string EOEEO1SPD1 = "EOEEO1SPD1";

        /// <summary>
        /// EOEEO1SPD2.
        /// </summary>
        public const string EOEEO1SPD2 = "EOEEO1SPD2";

        /// <summary>
        /// EOEEO1SPD3.
        /// </summary>
        public const string EOEEO1SPD3 = "EOEEO1SPD3";

        /// <summary>
        /// EOEEO1SPD4.
        /// </summary>
        public const string EOEEO1SPD4 = "EOEEO1SPD4";
    }

    /// <inheritdoc />
    public override string TableName => "F05850";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EOEEOCO", "EOEEOCO", JdeDataType.String, 16, true, true),
        new JdeField("EOEEOUNT", "EOEEOUNT", JdeDataType.String, 14, true, true),
        new JdeField("EOCENTYR", "EOCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("EOAN8", "EOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EOSIC", "EOSIC", JdeDataType.String, 20),
        new JdeField("EOCO", "EOCO", JdeDataType.String, 10),
        new JdeField("EOEEMW", "EOEEMW", JdeDataType.Numeric),
        new JdeField("EOEEMB", "EOEEMB", JdeDataType.Numeric),
        new JdeField("EOEEMH", "EOEEMH", JdeDataType.Numeric),
        new JdeField("EOEEMA", "EOEEMA", JdeDataType.Numeric),
        new JdeField("EOEEMI", "EOEEMI", JdeDataType.Numeric),
        new JdeField("EOEEFW", "EOEEFW", JdeDataType.Numeric),
        new JdeField("EOEEFB", "EOEEFB", JdeDataType.Numeric),
        new JdeField("EOEEFH", "EOEEFH", JdeDataType.Numeric),
        new JdeField("EOEEFA", "EOEEFA", JdeDataType.Numeric),
        new JdeField("EOEEFI", "EOEEFI", JdeDataType.Numeric),
        new JdeField("EOEEMP", "EOEEMP", JdeDataType.Numeric),
        new JdeField("EOEEFP", "EOEEFP", JdeDataType.Numeric),
        new JdeField("EOEEM2", "EOEEM2", JdeDataType.Numeric),
        new JdeField("EOEEF2", "EOEEF2", JdeDataType.Numeric),
        new JdeField("EOJOBN", "EOJOBN", JdeDataType.String, 20),
        new JdeField("EOUSER", "EOUSER", JdeDataType.String, 20),
        new JdeField("EOPID", "EOPID", JdeDataType.String, 20),
        new JdeField("EOUPMJ", "EOUPMJ", JdeDataType.Numeric),
        new JdeField("EOTDAY", "EOTDAY", JdeDataType.Numeric),
        new JdeField("EOEEOJ", "EOEEOJ", JdeDataType.String, 6, true, true),
        new JdeField("EOEEPB", "EOEEPB", JdeDataType.String, 6, true, true),
        new JdeField("EOEEMWH", "EOEEMWH", JdeDataType.Numeric),
        new JdeField("EOEEMBH", "EOEEMBH", JdeDataType.Numeric),
        new JdeField("EOEEMHH", "EOEEMHH", JdeDataType.Numeric),
        new JdeField("EOEEMAH", "EOEEMAH", JdeDataType.Numeric),
        new JdeField("EOEEMIH", "EOEEMIH", JdeDataType.Numeric),
        new JdeField("EOEEFWH", "EOEEFWH", JdeDataType.Numeric),
        new JdeField("EOEEFBH", "EOEEFBH", JdeDataType.Numeric),
        new JdeField("EOEEFHH", "EOEEFHH", JdeDataType.Numeric),
        new JdeField("EOEEFAH", "EOEEFAH", JdeDataType.Numeric),
        new JdeField("EOEEFIH", "EOEEFIH", JdeDataType.Numeric),
        new JdeField("EOEEMPH", "EOEEMPH", JdeDataType.Numeric),
        new JdeField("EOEEFPH", "EOEEFPH", JdeDataType.Numeric),
        new JdeField("EOEEM2H", "EOEEM2H", JdeDataType.Numeric),
        new JdeField("EOEEF2H", "EOEEF2H", JdeDataType.Numeric),
        new JdeField("EOEEO1SPS1", "EOEEO1SPS1", JdeDataType.String, 60),
        new JdeField("EOEEO1SPS2", "EOEEO1SPS2", JdeDataType.String, 60),
        new JdeField("EOEEO1SPS3", "EOEEO1SPS3", JdeDataType.String, 60),
        new JdeField("EOEEO1SPS4", "EOEEO1SPS4", JdeDataType.String, 60),
        new JdeField("EOEEO1SPN1", "EOEEO1SPN1", JdeDataType.Numeric),
        new JdeField("EOEEO1SPN2", "EOEEO1SPN2", JdeDataType.Numeric),
        new JdeField("EOEEO1SPN3", "EOEEO1SPN3", JdeDataType.Numeric),
        new JdeField("EOEEO1SPN4", "EOEEO1SPN4", JdeDataType.Numeric),
        new JdeField("EOEEO1SPC1", "EOEEO1SPC1", JdeDataType.String, 2),
        new JdeField("EOEEO1SPC2", "EOEEO1SPC2", JdeDataType.String, 2),
        new JdeField("EOEEO1SPC3", "EOEEO1SPC3", JdeDataType.String, 2),
        new JdeField("EOEEO1SPC4", "EOEEO1SPC4", JdeDataType.String, 2),
        new JdeField("EOEEO1SPD1", "EOEEO1SPD1", JdeDataType.Numeric),
        new JdeField("EOEEO1SPD2", "EOEEO1SPD2", JdeDataType.Numeric),
        new JdeField("EOEEO1SPD3", "EOEEO1SPD3", JdeDataType.Numeric),
        new JdeField("EOEEO1SPD4", "EOEEO1SPD4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05850_0", "Primary Key on EOEEOCO, EOEEOUNT, EOCENTYR, EOAN8, EOEEOJ, EOEEPB", new[] { "EOEEOCO", "EOEEOUNT", "EOCENTYR", "EOAN8", "EOEEOJ", "EOEEPB" }, isUnique: true, isPrimaryKey: true)
    };
}
