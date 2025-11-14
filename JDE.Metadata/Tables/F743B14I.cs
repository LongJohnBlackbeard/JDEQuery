using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743B14I - .
/// </summary>
public class F743B14I : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIPYID.
        /// </summary>
        public const string TIPYID = "TIPYID";

        /// <summary>
        /// TITYIN.
        /// </summary>
        public const string TITYIN = "TITYIN";

        /// <summary>
        /// TIRC5.
        /// </summary>
        public const string TIRC5 = "TIRC5";

        /// <summary>
        /// TIPOST.
        /// </summary>
        public const string TIPOST = "TIPOST";

        /// <summary>
        /// TICKNU.
        /// </summary>
        public const string TICKNU = "TICKNU";

        /// <summary>
        /// TIPN.
        /// </summary>
        public const string TIPN = "TIPN";

        /// <summary>
        /// TIICU.
        /// </summary>
        public const string TIICU = "TIICU";

        /// <summary>
        /// TIICUT.
        /// </summary>
        public const string TIICUT = "TIICUT";

        /// <summary>
        /// TIDICJ.
        /// </summary>
        public const string TIDICJ = "TIDICJ";

        /// <summary>
        /// TICO.
        /// </summary>
        public const string TICO = "TICO";

        /// <summary>
        /// TIUSER.
        /// </summary>
        public const string TIUSER = "TIUSER";

        /// <summary>
        /// TIAN8.
        /// </summary>
        public const string TIAN8 = "TIAN8";

        /// <summary>
        /// TIDCT.
        /// </summary>
        public const string TIDCT = "TIDCT";

        /// <summary>
        /// TIDOC.
        /// </summary>
        public const string TIDOC = "TIDOC";

        /// <summary>
        /// TISFX.
        /// </summary>
        public const string TISFX = "TISFX";

        /// <summary>
        /// TIDIJ.
        /// </summary>
        public const string TIDIJ = "TIDIJ";

        /// <summary>
        /// TIDGJ.
        /// </summary>
        public const string TIDGJ = "TIDGJ";

        /// <summary>
        /// TIDGY.
        /// </summary>
        public const string TIDGY = "TIDGY";

        /// <summary>
        /// TIDCTM.
        /// </summary>
        public const string TIDCTM = "TIDCTM";

        /// <summary>
        /// TIDMTJ.
        /// </summary>
        public const string TIDMTJ = "TIDMTJ";

        /// <summary>
        /// TIVINV.
        /// </summary>
        public const string TIVINV = "TIVINV";

        /// <summary>
        /// TITXA1.
        /// </summary>
        public const string TITXA1 = "TITXA1";

        /// <summary>
        /// TIGLC.
        /// </summary>
        public const string TIGLC = "TIGLC";

        /// <summary>
        /// TIGL01.
        /// </summary>
        public const string TIGL01 = "TIGL01";

        /// <summary>
        /// TILTXA.
        /// </summary>
        public const string TILTXA = "TILTXA";

        /// <summary>
        /// TIIIMP.
        /// </summary>
        public const string TIIIMP = "TIIIMP";

        /// <summary>
        /// TIIIPP.
        /// </summary>
        public const string TIIIPP = "TIIIPP";

        /// <summary>
        /// TIITDI.
        /// </summary>
        public const string TIITDI = "TIITDI";

        /// <summary>
        /// TITNDI.
        /// </summary>
        public const string TITNDI = "TITNDI";

        /// <summary>
        /// TIISFX.
        /// </summary>
        public const string TIISFX = "TIISFX";

        /// <summary>
        /// TIDTDO.
        /// </summary>
        public const string TIDTDO = "TIDTDO";

        /// <summary>
        /// TICTRY.
        /// </summary>
        public const string TICTRY = "TICTRY";

        /// <summary>
        /// TIFY.
        /// </summary>
        public const string TIFY = "TIFY";

        /// <summary>
        /// TIKCO.
        /// </summary>
        public const string TIKCO = "TIKCO";

        /// <summary>
        /// TIDIC#.
        /// </summary>
        public const string TIDIC_ = "TIDIC#";

        /// <summary>
        /// TIDG#.
        /// </summary>
        public const string TIDG_ = "TIDG#";

        /// <summary>
        /// TIFNLP.
        /// </summary>
        public const string TIFNLP = "TIFNLP";
    }

    /// <inheritdoc />
    public override string TableName => "F743B14I";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIPYID", "TIPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TITYIN", "TITYIN", JdeDataType.String, 2),
        new JdeField("TIRC5", "TIRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("TIPOST", "TIPOST", JdeDataType.String, 2),
        new JdeField("TICKNU", "TICKNU", JdeDataType.String, 50),
        new JdeField("TIPN", "TIPN", JdeDataType.Numeric),
        new JdeField("TIICU", "TIICU", JdeDataType.Numeric),
        new JdeField("TIICUT", "TIICUT", JdeDataType.String, 4),
        new JdeField("TIDICJ", "TIDICJ", JdeDataType.Numeric),
        new JdeField("TICO", "TICO", JdeDataType.String, 10),
        new JdeField("TIUSER", "TIUSER", JdeDataType.String, 20),
        new JdeField("TIAN8", "TIAN8", JdeDataType.Numeric),
        new JdeField("TIDCT", "TIDCT", JdeDataType.String, 4),
        new JdeField("TIDOC", "TIDOC", JdeDataType.Numeric),
        new JdeField("TISFX", "TISFX", JdeDataType.String, 6),
        new JdeField("TIDIJ", "TIDIJ", JdeDataType.Numeric),
        new JdeField("TIDGJ", "TIDGJ", JdeDataType.Numeric),
        new JdeField("TIDGY", "TIDGY", JdeDataType.Numeric),
        new JdeField("TIDCTM", "TIDCTM", JdeDataType.String, 4),
        new JdeField("TIDMTJ", "TIDMTJ", JdeDataType.Numeric),
        new JdeField("TIVINV", "TIVINV", JdeDataType.String, 50),
        new JdeField("TITXA1", "TITXA1", JdeDataType.String, 20),
        new JdeField("TIGLC", "TIGLC", JdeDataType.String, 8),
        new JdeField("TIGL01", "TIGL01", JdeDataType.String, 8),
        new JdeField("TILTXA", "TILTXA", JdeDataType.String, 20),
        new JdeField("TIIIMP", "TIIIMP", JdeDataType.Numeric),
        new JdeField("TIIIPP", "TIIIPP", JdeDataType.Numeric),
        new JdeField("TIITDI", "TIITDI", JdeDataType.String, 4),
        new JdeField("TITNDI", "TITNDI", JdeDataType.Numeric),
        new JdeField("TIISFX", "TIISFX", JdeDataType.String, 6),
        new JdeField("TIDTDO", "TIDTDO", JdeDataType.Numeric),
        new JdeField("TICTRY", "TICTRY", JdeDataType.Numeric),
        new JdeField("TIFY", "TIFY", JdeDataType.Numeric),
        new JdeField("TIKCO", "TIKCO", JdeDataType.String, 10),
        new JdeField("TIDIC#", "TIDIC#", JdeDataType.Numeric),
        new JdeField("TIDG#", "TIDG#", JdeDataType.Numeric),
        new JdeField("TIFNLP", "TIFNLP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743B14I_0", "Primary Key on TIPYID, TIRC5", new[] { "TIPYID", "TIRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F743B14I_3", "Index on TIPYID, TITYIN", new[] { "TIPYID", "TITYIN" })
    };
}
