using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1514Z1 - .
/// </summary>
public class F1514Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMEDUS.
        /// </summary>
        public const string AMEDUS = "AMEDUS";

        /// <summary>
        /// AMEDBT.
        /// </summary>
        public const string AMEDBT = "AMEDBT";

        /// <summary>
        /// AMEDTN.
        /// </summary>
        public const string AMEDTN = "AMEDTN";

        /// <summary>
        /// AMEDLN.
        /// </summary>
        public const string AMEDLN = "AMEDLN";

        /// <summary>
        /// AMEDCT.
        /// </summary>
        public const string AMEDCT = "AMEDCT";

        /// <summary>
        /// AMTYTN.
        /// </summary>
        public const string AMTYTN = "AMTYTN";

        /// <summary>
        /// AMEDFT.
        /// </summary>
        public const string AMEDFT = "AMEDFT";

        /// <summary>
        /// AMEDDT.
        /// </summary>
        public const string AMEDDT = "AMEDDT";

        /// <summary>
        /// AMDRIN.
        /// </summary>
        public const string AMDRIN = "AMDRIN";

        /// <summary>
        /// AMEDDL.
        /// </summary>
        public const string AMEDDL = "AMEDDL";

        /// <summary>
        /// AMEDSP.
        /// </summary>
        public const string AMEDSP = "AMEDSP";

        /// <summary>
        /// AMPNID.
        /// </summary>
        public const string AMPNID = "AMPNID";

        /// <summary>
        /// AMTNAC.
        /// </summary>
        public const string AMTNAC = "AMTNAC";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMTDAY.
        /// </summary>
        public const string AMTDAY = "AMTDAY";

        /// <summary>
        /// AMMCU.
        /// </summary>
        public const string AMMCU = "AMMCU";

        /// <summary>
        /// AMFLOR.
        /// </summary>
        public const string AMFLOR = "AMFLOR";

        /// <summary>
        /// AMUNIT.
        /// </summary>
        public const string AMUNIT = "AMUNIT";

        /// <summary>
        /// AMARTY.
        /// </summary>
        public const string AMARTY = "AMARTY";

        /// <summary>
        /// AMARGC.
        /// </summary>
        public const string AMARGC = "AMARGC";

        /// <summary>
        /// AMARGV.
        /// </summary>
        public const string AMARGV = "AMARGV";

        /// <summary>
        /// AMDL01.
        /// </summary>
        public const string AMDL01 = "AMDL01";

        /// <summary>
        /// AMARLL.
        /// </summary>
        public const string AMARLL = "AMARLL";

        /// <summary>
        /// AMSEQ.
        /// </summary>
        public const string AMSEQ = "AMSEQ";

        /// <summary>
        /// AMPMU1.
        /// </summary>
        public const string AMPMU1 = "AMPMU1";

        /// <summary>
        /// AMUM.
        /// </summary>
        public const string AMUM = "AMUM";

        /// <summary>
        /// AMEFTB.
        /// </summary>
        public const string AMEFTB = "AMEFTB";

        /// <summary>
        /// AMEFTE.
        /// </summary>
        public const string AMEFTE = "AMEFTE";

        /// <summary>
        /// AMURCD.
        /// </summary>
        public const string AMURCD = "AMURCD";

        /// <summary>
        /// AMURDT.
        /// </summary>
        public const string AMURDT = "AMURDT";

        /// <summary>
        /// AMURAT.
        /// </summary>
        public const string AMURAT = "AMURAT";

        /// <summary>
        /// AMURAB.
        /// </summary>
        public const string AMURAB = "AMURAB";

        /// <summary>
        /// AMURRF.
        /// </summary>
        public const string AMURRF = "AMURRF";

        /// <summary>
        /// AMENTJ.
        /// </summary>
        public const string AMENTJ = "AMENTJ";

        /// <summary>
        /// AMTORG.
        /// </summary>
        public const string AMTORG = "AMTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F1514Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMEDUS", "AMEDUS", JdeDataType.String, 20, true, true),
        new JdeField("AMEDBT", "AMEDBT", JdeDataType.String, 30, true, true),
        new JdeField("AMEDTN", "AMEDTN", JdeDataType.String, 44, true, true),
        new JdeField("AMEDLN", "AMEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AMEDCT", "AMEDCT", JdeDataType.String, 4),
        new JdeField("AMTYTN", "AMTYTN", JdeDataType.String, 16),
        new JdeField("AMEDFT", "AMEDFT", JdeDataType.String, 20),
        new JdeField("AMEDDT", "AMEDDT", JdeDataType.Numeric),
        new JdeField("AMDRIN", "AMDRIN", JdeDataType.String, 2),
        new JdeField("AMEDDL", "AMEDDL", JdeDataType.Numeric),
        new JdeField("AMEDSP", "AMEDSP", JdeDataType.String, 2),
        new JdeField("AMPNID", "AMPNID", JdeDataType.String, 30),
        new JdeField("AMTNAC", "AMTNAC", JdeDataType.String, 4),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMTDAY", "AMTDAY", JdeDataType.Numeric),
        new JdeField("AMMCU", "AMMCU", JdeDataType.String, 24),
        new JdeField("AMFLOR", "AMFLOR", JdeDataType.String, 8),
        new JdeField("AMUNIT", "AMUNIT", JdeDataType.String, 16),
        new JdeField("AMARTY", "AMARTY", JdeDataType.String, 6),
        new JdeField("AMARGC", "AMARGC", JdeDataType.String, 8),
        new JdeField("AMARGV", "AMARGV", JdeDataType.String, 10),
        new JdeField("AMDL01", "AMDL01", JdeDataType.String, 60),
        new JdeField("AMARLL", "AMARLL", JdeDataType.String, 2),
        new JdeField("AMSEQ", "AMSEQ", JdeDataType.Numeric),
        new JdeField("AMPMU1", "AMPMU1", JdeDataType.Numeric),
        new JdeField("AMUM", "AMUM", JdeDataType.String, 4),
        new JdeField("AMEFTB", "AMEFTB", JdeDataType.Numeric),
        new JdeField("AMEFTE", "AMEFTE", JdeDataType.Numeric),
        new JdeField("AMURCD", "AMURCD", JdeDataType.String, 4),
        new JdeField("AMURDT", "AMURDT", JdeDataType.Numeric),
        new JdeField("AMURAT", "AMURAT", JdeDataType.Numeric),
        new JdeField("AMURAB", "AMURAB", JdeDataType.Numeric),
        new JdeField("AMURRF", "AMURRF", JdeDataType.String, 30),
        new JdeField("AMENTJ", "AMENTJ", JdeDataType.Numeric),
        new JdeField("AMTORG", "AMTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1514Z1_0", "Primary Key on AMEDUS, AMEDBT, AMEDTN, AMEDLN", new[] { "AMEDUS", "AMEDBT", "AMEDTN", "AMEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
