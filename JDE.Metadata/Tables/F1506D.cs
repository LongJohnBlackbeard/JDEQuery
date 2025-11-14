using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1506D - .
/// </summary>
public class F1506D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPMCU.
        /// </summary>
        public const string OPMCU = "OPMCU";

        /// <summary>
        /// OPFLOR.
        /// </summary>
        public const string OPFLOR = "OPFLOR";

        /// <summary>
        /// OPARGC.
        /// </summary>
        public const string OPARGC = "OPARGC";

        /// <summary>
        /// OPARGV.
        /// </summary>
        public const string OPARGV = "OPARGV";

        /// <summary>
        /// OPLNGP.
        /// </summary>
        public const string OPLNGP = "OPLNGP";

        /// <summary>
        /// OPDL01.
        /// </summary>
        public const string OPDL01 = "OPDL01";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPUPMT.
        /// </summary>
        public const string OPUPMT = "OPUPMT";

        /// <summary>
        /// OPJOBN.
        /// </summary>
        public const string OPJOBN = "OPJOBN";

        /// <summary>
        /// OPTORG.
        /// </summary>
        public const string OPTORG = "OPTORG";

        /// <summary>
        /// OPENTJ.
        /// </summary>
        public const string OPENTJ = "OPENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1506D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPMCU", "OPMCU", JdeDataType.String, 24, true, true),
        new JdeField("OPFLOR", "OPFLOR", JdeDataType.String, 8, true, true),
        new JdeField("OPARGC", "OPARGC", JdeDataType.String, 8, true, true),
        new JdeField("OPARGV", "OPARGV", JdeDataType.String, 10, true, true),
        new JdeField("OPLNGP", "OPLNGP", JdeDataType.String, 4, true, true),
        new JdeField("OPDL01", "OPDL01", JdeDataType.String, 60),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPUPMT", "OPUPMT", JdeDataType.Numeric),
        new JdeField("OPJOBN", "OPJOBN", JdeDataType.String, 20),
        new JdeField("OPTORG", "OPTORG", JdeDataType.String, 20),
        new JdeField("OPENTJ", "OPENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1506D_0", "Primary Key on OPMCU, OPFLOR, OPARGC, OPARGV, OPLNGP", new[] { "OPMCU", "OPFLOR", "OPARGC", "OPARGV", "OPLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
