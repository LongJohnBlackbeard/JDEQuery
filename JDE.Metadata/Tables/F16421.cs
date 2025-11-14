using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F16421 - .
/// </summary>
public class F16421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDRHID.
        /// </summary>
        public const string RDRHID = "RDRHID";

        /// <summary>
        /// RDITM.
        /// </summary>
        public const string RDITM = "RDITM";

        /// <summary>
        /// RDABR1.
        /// </summary>
        public const string RDABR1 = "RDABR1";

        /// <summary>
        /// RDABT1.
        /// </summary>
        public const string RDABT1 = "RDABT1";

        /// <summary>
        /// RDABR2.
        /// </summary>
        public const string RDABR2 = "RDABR2";

        /// <summary>
        /// RDABT2.
        /// </summary>
        public const string RDABT2 = "RDABT2";

        /// <summary>
        /// RDABR3.
        /// </summary>
        public const string RDABR3 = "RDABR3";

        /// <summary>
        /// RDABT3.
        /// </summary>
        public const string RDABT3 = "RDABT3";

        /// <summary>
        /// RDABR4.
        /// </summary>
        public const string RDABR4 = "RDABR4";

        /// <summary>
        /// RDABT4.
        /// </summary>
        public const string RDABT4 = "RDABT4";

        /// <summary>
        /// RDSBL.
        /// </summary>
        public const string RDSBL = "RDSBL";

        /// <summary>
        /// RDSBLT.
        /// </summary>
        public const string RDSBLT = "RDSBLT";

        /// <summary>
        /// RDRATE.
        /// </summary>
        public const string RDRATE = "RDRATE";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F16421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDRHID", "RDRHID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDITM", "RDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RDABR1", "RDABR1", JdeDataType.String, 24, true, true),
        new JdeField("RDABT1", "RDABT1", JdeDataType.String, 2, true, true),
        new JdeField("RDABR2", "RDABR2", JdeDataType.String, 24, true, true),
        new JdeField("RDABT2", "RDABT2", JdeDataType.String, 2, true, true),
        new JdeField("RDABR3", "RDABR3", JdeDataType.String, 24, true, true),
        new JdeField("RDABT3", "RDABT3", JdeDataType.String, 2, true, true),
        new JdeField("RDABR4", "RDABR4", JdeDataType.String, 24, true, true),
        new JdeField("RDABT4", "RDABT4", JdeDataType.String, 2, true, true),
        new JdeField("RDSBL", "RDSBL", JdeDataType.String, 16, true, true),
        new JdeField("RDSBLT", "RDSBLT", JdeDataType.String, 2, true, true),
        new JdeField("RDRATE", "RDRATE", JdeDataType.Numeric),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F16421_0", "Primary Key on RDRHID, RDITM, RDABR1, RDABT1, RDABR2, RDABT2, RDABR3, RDABT3, RDABR4, RDABT4, RDSBL, RDSBLT", new[] { "RDRHID", "RDITM", "RDABR1", "RDABT1", "RDABR2", "RDABT2", "RDABR3", "RDABT3", "RDABR4", "RDABT4", "RDSBL", "RDSBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
