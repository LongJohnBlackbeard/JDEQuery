using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98231D - .
/// </summary>
public class F98231D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDALPH.
        /// </summary>
        public const string TDALPH = "TDALPH";

        /// <summary>
        /// TDOMWAC.
        /// </summary>
        public const string TDOMWAC = "TDOMWAC";

        /// <summary>
        /// TDOMWPSTO.
        /// </summary>
        public const string TDOMWPSTO = "TDOMWPSTO";

        /// <summary>
        /// TDOMWFPS.
        /// </summary>
        public const string TDOMWFPS = "TDOMWFPS";

        /// <summary>
        /// TDOMWUSER.
        /// </summary>
        public const string TDOMWUSER = "TDOMWUSER";

        /// <summary>
        /// TDMATH01.
        /// </summary>
        public const string TDMATH01 = "TDMATH01";

        /// <summary>
        /// TDDL01.
        /// </summary>
        public const string TDDL01 = "TDDL01";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDEV01.
        /// </summary>
        public const string TDEV01 = "TDEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F98231D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDALPH", "TDALPH", JdeDataType.String, 80, true, true),
        new JdeField("TDOMWAC", "TDOMWAC", JdeDataType.String, 10, true, true),
        new JdeField("TDOMWPSTO", "TDOMWPSTO", JdeDataType.String, 10, true, true),
        new JdeField("TDOMWFPS", "TDOMWFPS", JdeDataType.String, 10, true, true),
        new JdeField("TDOMWUSER", "TDOMWUSER", JdeDataType.String, 20, true, true),
        new JdeField("TDMATH01", "TDMATH01", JdeDataType.Numeric),
        new JdeField("TDDL01", "TDDL01", JdeDataType.String, 60),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDEV01", "TDEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98231D_0", "Primary Key on TDALPH, TDOMWAC, TDOMWPSTO, TDOMWFPS, TDOMWUSER", new[] { "TDALPH", "TDOMWAC", "TDOMWPSTO", "TDOMWFPS", "TDOMWUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
