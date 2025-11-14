using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051171 - .
/// </summary>
public class F051171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLGOAL.
        /// </summary>
        public const string GLGOAL = "GLGOAL";

        /// <summary>
        /// GLGSEQ.
        /// </summary>
        public const string GLGSEQ = "GLGSEQ";

        /// <summary>
        /// GLGAID.
        /// </summary>
        public const string GLGAID = "GLGAID";

        /// <summary>
        /// GLSGID.
        /// </summary>
        public const string GLSGID = "GLSGID";

        /// <summary>
        /// GLGASTS.
        /// </summary>
        public const string GLGASTS = "GLGASTS";

        /// <summary>
        /// GLGAD.
        /// </summary>
        public const string GLGAD = "GLGAD";

        /// <summary>
        /// GLGLDT.
        /// </summary>
        public const string GLGLDT = "GLGLDT";

        /// <summary>
        /// GLESD.
        /// </summary>
        public const string GLESD = "GLESD";

        /// <summary>
        /// GLESED.
        /// </summary>
        public const string GLESED = "GLESED";

        /// <summary>
        /// GLTREN.
        /// </summary>
        public const string GLTREN = "GLTREN";

        /// <summary>
        /// GLTRSD.
        /// </summary>
        public const string GLTRSD = "GLTRSD";

        /// <summary>
        /// GLCHRN.
        /// </summary>
        public const string GLCHRN = "GLCHRN";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLGCB.
        /// </summary>
        public const string GLGCB = "GLGCB";

        /// <summary>
        /// GLGOT.
        /// </summary>
        public const string GLGOT = "GLGOT";

        /// <summary>
        /// GLALPH.
        /// </summary>
        public const string GLALPH = "GLALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F051171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLGOAL", "GLGOAL", JdeDataType.String, 20, true, true),
        new JdeField("GLGSEQ", "GLGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLGAID", "GLGAID", JdeDataType.Numeric, null, true, true),
        new JdeField("GLSGID", "GLSGID", JdeDataType.Numeric),
        new JdeField("GLGASTS", "GLGASTS", JdeDataType.String, 8),
        new JdeField("GLGAD", "GLGAD", JdeDataType.String, 200),
        new JdeField("GLGLDT", "GLGLDT", JdeDataType.Numeric),
        new JdeField("GLESD", "GLESD", JdeDataType.Numeric),
        new JdeField("GLESED", "GLESED", JdeDataType.Numeric),
        new JdeField("GLTREN", "GLTREN", JdeDataType.Numeric),
        new JdeField("GLTRSD", "GLTRSD", JdeDataType.Numeric),
        new JdeField("GLCHRN", "GLCHRN", JdeDataType.String, 6),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLGCB", "GLGCB", JdeDataType.Numeric),
        new JdeField("GLGOT", "GLGOT", JdeDataType.String, 10),
        new JdeField("GLALPH", "GLALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051171_0", "Primary Key on GLGOAL, GLGSEQ, GLGAID", new[] { "GLGOAL", "GLGSEQ", "GLGAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F051171_2", "Index on GLGOAL, GLGSEQ, GLSGID", new[] { "GLGOAL", "GLGSEQ", "GLSGID" }),
        new JdeIndex("F051171_3", "Index on GLGOAL, SYS_NC00021$", new[] { "GLGOAL", "SYS_NC00021$" }),
        new JdeIndex("F051171_4", "Index on GLGOAL, GLALPH", new[] { "GLGOAL", "GLALPH" }),
        new JdeIndex("F051171_5", "Index on GLGOAL, GLGASTS", new[] { "GLGOAL", "GLGASTS" })
    };
}
