using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M413 - .
/// </summary>
public class F76M413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MWPYID.
        /// </summary>
        public const string MWPYID = "MWPYID";

        /// <summary>
        /// MWM76WHTP.
        /// </summary>
        public const string MWM76WHTP = "MWM76WHTP";

        /// <summary>
        /// MWM76WCON.
        /// </summary>
        public const string MWM76WCON = "MWM76WCON";

        /// <summary>
        /// MWM76LCON.
        /// </summary>
        public const string MWM76LCON = "MWM76LCON";

        /// <summary>
        /// MWDOCM.
        /// </summary>
        public const string MWDOCM = "MWDOCM";

        /// <summary>
        /// MWKCO.
        /// </summary>
        public const string MWKCO = "MWKCO";

        /// <summary>
        /// MWDOC.
        /// </summary>
        public const string MWDOC = "MWDOC";

        /// <summary>
        /// MWDCT.
        /// </summary>
        public const string MWDCT = "MWDCT";

        /// <summary>
        /// MWAA.
        /// </summary>
        public const string MWAA = "MWAA";

        /// <summary>
        /// MWACR.
        /// </summary>
        public const string MWACR = "MWACR";

        /// <summary>
        /// MWTAXE.
        /// </summary>
        public const string MWTAXE = "MWTAXE";

        /// <summary>
        /// MWM76WPER.
        /// </summary>
        public const string MWM76WPER = "MWM76WPER";

        /// <summary>
        /// MWM76ASWH.
        /// </summary>
        public const string MWM76ASWH = "MWM76ASWH";

        /// <summary>
        /// MWM76GORT.
        /// </summary>
        public const string MWM76GORT = "MWM76GORT";

        /// <summary>
        /// MWM76FDAT.
        /// </summary>
        public const string MWM76FDAT = "MWM76FDAT";

        /// <summary>
        /// MWM76FFLG.
        /// </summary>
        public const string MWM76FFLG = "MWM76FFLG";

        /// <summary>
        /// MWM76FNUM.
        /// </summary>
        public const string MWM76FNUM = "MWM76FNUM";

        /// <summary>
        /// MWM76FSTR.
        /// </summary>
        public const string MWM76FSTR = "MWM76FSTR";

        /// <summary>
        /// MWUSER.
        /// </summary>
        public const string MWUSER = "MWUSER";

        /// <summary>
        /// MWPID.
        /// </summary>
        public const string MWPID = "MWPID";

        /// <summary>
        /// MWJOBN.
        /// </summary>
        public const string MWJOBN = "MWJOBN";

        /// <summary>
        /// MWUPMJ.
        /// </summary>
        public const string MWUPMJ = "MWUPMJ";

        /// <summary>
        /// MWUPMT.
        /// </summary>
        public const string MWUPMT = "MWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MWPYID", "MWPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("MWM76WHTP", "MWM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("MWM76WCON", "MWM76WCON", JdeDataType.String, 6, true, true),
        new JdeField("MWM76LCON", "MWM76LCON", JdeDataType.String, 6),
        new JdeField("MWDOCM", "MWDOCM", JdeDataType.Numeric),
        new JdeField("MWKCO", "MWKCO", JdeDataType.String, 10),
        new JdeField("MWDOC", "MWDOC", JdeDataType.Numeric),
        new JdeField("MWDCT", "MWDCT", JdeDataType.String, 4),
        new JdeField("MWAA", "MWAA", JdeDataType.Numeric),
        new JdeField("MWACR", "MWACR", JdeDataType.Numeric),
        new JdeField("MWTAXE", "MWTAXE", JdeDataType.Numeric),
        new JdeField("MWM76WPER", "MWM76WPER", JdeDataType.Numeric),
        new JdeField("MWM76ASWH", "MWM76ASWH", JdeDataType.Numeric),
        new JdeField("MWM76GORT", "MWM76GORT", JdeDataType.String, 2),
        new JdeField("MWM76FDAT", "MWM76FDAT", JdeDataType.Numeric),
        new JdeField("MWM76FFLG", "MWM76FFLG", JdeDataType.String, 2),
        new JdeField("MWM76FNUM", "MWM76FNUM", JdeDataType.Numeric),
        new JdeField("MWM76FSTR", "MWM76FSTR", JdeDataType.String, 60),
        new JdeField("MWUSER", "MWUSER", JdeDataType.String, 20),
        new JdeField("MWPID", "MWPID", JdeDataType.String, 20),
        new JdeField("MWJOBN", "MWJOBN", JdeDataType.String, 20),
        new JdeField("MWUPMJ", "MWUPMJ", JdeDataType.Numeric),
        new JdeField("MWUPMT", "MWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M413_0", "Primary Key on MWPYID, MWM76WHTP, MWM76WCON", new[] { "MWPYID", "MWM76WHTP", "MWM76WCON" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M413_2", "Index on MWPYID, MWM76WHTP, MWM76WCON, MWM76LCON", new[] { "MWPYID", "MWM76WHTP", "MWM76WCON", "MWM76LCON" })
    };
}
