using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M414 - .
/// </summary>
public class F76M414 : JdeTable
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
        /// MWRC5.
        /// </summary>
        public const string MWRC5 = "MWRC5";

        /// <summary>
        /// MWM76WHTP.
        /// </summary>
        public const string MWM76WHTP = "MWM76WHTP";

        /// <summary>
        /// MWM76WPER.
        /// </summary>
        public const string MWM76WPER = "MWM76WPER";

        /// <summary>
        /// MWAA.
        /// </summary>
        public const string MWAA = "MWAA";

        /// <summary>
        /// MWM76GORT.
        /// </summary>
        public const string MWM76GORT = "MWM76GORT";

        /// <summary>
        /// MWM76WCON.
        /// </summary>
        public const string MWM76WCON = "MWM76WCON";

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
    public override string TableName => "F76M414";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MWPYID", "MWPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("MWRC5", "MWRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("MWM76WHTP", "MWM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("MWM76WPER", "MWM76WPER", JdeDataType.Numeric),
        new JdeField("MWAA", "MWAA", JdeDataType.Numeric),
        new JdeField("MWM76GORT", "MWM76GORT", JdeDataType.String, 2),
        new JdeField("MWM76WCON", "MWM76WCON", JdeDataType.String, 6),
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
        new JdeIndex("F76M414_0", "Primary Key on MWPYID, MWRC5, MWM76WHTP", new[] { "MWPYID", "MWRC5", "MWM76WHTP" }, isUnique: true, isPrimaryKey: true)
    };
}
