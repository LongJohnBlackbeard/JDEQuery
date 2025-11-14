using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F007021W - .
/// </summary>
public class F007021W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TBUSER.
        /// </summary>
        public const string TBUSER = "TBUSER";

        /// <summary>
        /// TBUKID.
        /// </summary>
        public const string TBUKID = "TBUKID";

        /// <summary>
        /// TBOBNM.
        /// </summary>
        public const string TBOBNM = "TBOBNM";

        /// <summary>
        /// TBICUT.
        /// </summary>
        public const string TBICUT = "TBICUT";

        /// <summary>
        /// TBICU.
        /// </summary>
        public const string TBICU = "TBICU";

        /// <summary>
        /// TBIST.
        /// </summary>
        public const string TBIST = "TBIST";

        /// <summary>
        /// TBDICJ.
        /// </summary>
        public const string TBDICJ = "TBDICJ";

        /// <summary>
        /// TBPOST.
        /// </summary>
        public const string TBPOST = "TBPOST";

        /// <summary>
        /// TBDCT.
        /// </summary>
        public const string TBDCT = "TBDCT";

        /// <summary>
        /// TBDOC.
        /// </summary>
        public const string TBDOC = "TBDOC";

        /// <summary>
        /// TBKCO.
        /// </summary>
        public const string TBKCO = "TBKCO";

        /// <summary>
        /// TBDGJ.
        /// </summary>
        public const string TBDGJ = "TBDGJ";

        /// <summary>
        /// TBMICU.
        /// </summary>
        public const string TBMICU = "TBMICU";

        /// <summary>
        /// TBMICUT.
        /// </summary>
        public const string TBMICUT = "TBMICUT";

        /// <summary>
        /// TBAN8.
        /// </summary>
        public const string TBAN8 = "TBAN8";

        /// <summary>
        /// TBPYID.
        /// </summary>
        public const string TBPYID = "TBPYID";

        /// <summary>
        /// TBTRCNT.
        /// </summary>
        public const string TBTRCNT = "TBTRCNT";
    }

    /// <inheritdoc />
    public override string TableName => "F007021W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TBUSER", "TBUSER", JdeDataType.String, 20, true, true),
        new JdeField("TBUKID", "TBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TBOBNM", "TBOBNM", JdeDataType.String, 20, true, true),
        new JdeField("TBICUT", "TBICUT", JdeDataType.String, 4, true, true),
        new JdeField("TBICU", "TBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("TBIST", "TBIST", JdeDataType.String, 2),
        new JdeField("TBDICJ", "TBDICJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TBPOST", "TBPOST", JdeDataType.String, 2, true, true),
        new JdeField("TBDCT", "TBDCT", JdeDataType.String, 4, true, true),
        new JdeField("TBDOC", "TBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TBKCO", "TBKCO", JdeDataType.String, 10, true, true),
        new JdeField("TBDGJ", "TBDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TBMICU", "TBMICU", JdeDataType.Numeric),
        new JdeField("TBMICUT", "TBMICUT", JdeDataType.String, 4),
        new JdeField("TBAN8", "TBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TBPYID", "TBPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TBTRCNT", "TBTRCNT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F007021W_0", "Primary Key on TBUSER, TBUKID, TBOBNM, TBICUT, TBICU, TBDICJ, TBDCT, TBDOC, TBKCO, TBDGJ, TBPYID, TBAN8, TBPOST", new[] { "TBUSER", "TBUKID", "TBOBNM", "TBICUT", "TBICU", "TBDICJ", "TBDCT", "TBDOC", "TBKCO", "TBDGJ", "TBPYID", "TBAN8", "TBPOST" }, isUnique: true, isPrimaryKey: true)
    };
}
