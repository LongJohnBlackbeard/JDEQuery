using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F40W - .
/// </summary>
public class F51F40W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LR51FFID.
        /// </summary>
        public const string LR51FFID = "LR51FFID";

        /// <summary>
        /// LRAID.
        /// </summary>
        public const string LRAID = "LRAID";

        /// <summary>
        /// LR51FAIDCL.
        /// </summary>
        public const string LR51FAIDCL = "LR51FAIDCL";

        /// <summary>
        /// LRLDA.
        /// </summary>
        public const string LRLDA = "LRLDA";

        /// <summary>
        /// LRCCT.
        /// </summary>
        public const string LRCCT = "LRCCT";

        /// <summary>
        /// LRUM.
        /// </summary>
        public const string LRUM = "LRUM";

        /// <summary>
        /// LR51FAA01.
        /// </summary>
        public const string LR51FAA01 = "LR51FAA01";

        /// <summary>
        /// LR51FAU01.
        /// </summary>
        public const string LR51FAU01 = "LR51FAU01";

        /// <summary>
        /// LR51FAAL01.
        /// </summary>
        public const string LR51FAAL01 = "LR51FAAL01";

        /// <summary>
        /// LR51FAUL01.
        /// </summary>
        public const string LR51FAUL01 = "LR51FAUL01";

        /// <summary>
        /// LRMCU.
        /// </summary>
        public const string LRMCU = "LRMCU";

        /// <summary>
        /// LRSUB.
        /// </summary>
        public const string LRSUB = "LRSUB";

        /// <summary>
        /// LROBJ.
        /// </summary>
        public const string LROBJ = "LROBJ";
    }

    /// <inheritdoc />
    public override string TableName => "F51F40W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20, true, true),
        new JdeField("LR51FFID", "LR51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRAID", "LRAID", JdeDataType.String, 16, true, true),
        new JdeField("LR51FAIDCL", "LR51FAIDCL", JdeDataType.String, 16, true, true),
        new JdeField("LRLDA", "LRLDA", JdeDataType.String, 2),
        new JdeField("LRCCT", "LRCCT", JdeDataType.String, 2),
        new JdeField("LRUM", "LRUM", JdeDataType.String, 4),
        new JdeField("LR51FAA01", "LR51FAA01", JdeDataType.Numeric),
        new JdeField("LR51FAU01", "LR51FAU01", JdeDataType.Numeric),
        new JdeField("LR51FAAL01", "LR51FAAL01", JdeDataType.Numeric),
        new JdeField("LR51FAUL01", "LR51FAUL01", JdeDataType.Numeric),
        new JdeField("LRMCU", "LRMCU", JdeDataType.String, 24),
        new JdeField("LRSUB", "LRSUB", JdeDataType.String, 16),
        new JdeField("LROBJ", "LROBJ", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F40W_0", "Primary Key on LRUSER, LR51FFID, LRAID, LR51FAIDCL", new[] { "LRUSER", "LR51FFID", "LRAID", "LR51FAIDCL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51F40W_2", "Index on LRUSER, LR51FFID, LR51FAIDCL", new[] { "LRUSER", "LR51FFID", "LR51FAIDCL" }),
        new JdeIndex("F51F40W_3", "Index on LRUSER, LR51FFID, LRMCU, LRSUB, LROBJ", new[] { "LRUSER", "LR51FFID", "LRMCU", "LRSUB", "LROBJ" })
    };
}
