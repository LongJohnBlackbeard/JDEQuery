using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079425 - .
/// </summary>
public class F079425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRPWPDBA.
        /// </summary>
        public const string PRPWPDBA = "PRPWPDBA";

        /// <summary>
        /// PRPDBA.
        /// </summary>
        public const string PRPDBA = "PRPDBA";

        /// <summary>
        /// PRPWPT.
        /// </summary>
        public const string PRPWPT = "PRPWPT";

        /// <summary>
        /// PRPWRC.
        /// </summary>
        public const string PRPWRC = "PRPWRC";

        /// <summary>
        /// PRPWAR.
        /// </summary>
        public const string PRPWAR = "PRPWAR";

        /// <summary>
        /// PRPWHPY.
        /// </summary>
        public const string PRPWHPY = "PRPWHPY";

        /// <summary>
        /// PRPWMULT.
        /// </summary>
        public const string PRPWMULT = "PRPWMULT";

        /// <summary>
        /// PRPWFMN04.
        /// </summary>
        public const string PRPWFMN04 = "PRPWFMN04";

        /// <summary>
        /// PRPWFMN05.
        /// </summary>
        public const string PRPWFMN05 = "PRPWFMN05";

        /// <summary>
        /// PRPWFMN06.
        /// </summary>
        public const string PRPWFMN06 = "PRPWFMN06";

        /// <summary>
        /// PRPWFST04.
        /// </summary>
        public const string PRPWFST04 = "PRPWFST04";

        /// <summary>
        /// PRPWFST05.
        /// </summary>
        public const string PRPWFST05 = "PRPWFST05";

        /// <summary>
        /// PRPWFST06.
        /// </summary>
        public const string PRPWFST06 = "PRPWFST06";

        /// <summary>
        /// PRPWFCH04.
        /// </summary>
        public const string PRPWFCH04 = "PRPWFCH04";

        /// <summary>
        /// PRPWFCH05.
        /// </summary>
        public const string PRPWFCH05 = "PRPWFCH05";

        /// <summary>
        /// PRPWFCH06.
        /// </summary>
        public const string PRPWFCH06 = "PRPWFCH06";

        /// <summary>
        /// PRPWFJD04.
        /// </summary>
        public const string PRPWFJD04 = "PRPWFJD04";

        /// <summary>
        /// PRPWFJD05.
        /// </summary>
        public const string PRPWFJD05 = "PRPWFJD05";

        /// <summary>
        /// PRPWFJD06.
        /// </summary>
        public const string PRPWFJD06 = "PRPWFJD06";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F079425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRPWPDBA", "PRPWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPDBA", "PRPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPWPT", "PRPWPT", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPWRC", "PRPWRC", JdeDataType.String, 2),
        new JdeField("PRPWAR", "PRPWAR", JdeDataType.String, 2),
        new JdeField("PRPWHPY", "PRPWHPY", JdeDataType.Numeric),
        new JdeField("PRPWMULT", "PRPWMULT", JdeDataType.Numeric),
        new JdeField("PRPWFMN04", "PRPWFMN04", JdeDataType.Numeric),
        new JdeField("PRPWFMN05", "PRPWFMN05", JdeDataType.Numeric),
        new JdeField("PRPWFMN06", "PRPWFMN06", JdeDataType.Numeric),
        new JdeField("PRPWFST04", "PRPWFST04", JdeDataType.String, 40),
        new JdeField("PRPWFST05", "PRPWFST05", JdeDataType.String, 40),
        new JdeField("PRPWFST06", "PRPWFST06", JdeDataType.String, 80),
        new JdeField("PRPWFCH04", "PRPWFCH04", JdeDataType.String, 2),
        new JdeField("PRPWFCH05", "PRPWFCH05", JdeDataType.String, 2),
        new JdeField("PRPWFCH06", "PRPWFCH06", JdeDataType.String, 2),
        new JdeField("PRPWFJD04", "PRPWFJD04", JdeDataType.Numeric),
        new JdeField("PRPWFJD05", "PRPWFJD05", JdeDataType.Numeric),
        new JdeField("PRPWFJD06", "PRPWFJD06", JdeDataType.Numeric),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079425_0", "Primary Key on PRPWPDBA, PRPDBA, PRPWPT", new[] { "PRPWPDBA", "PRPDBA", "PRPWPT" }, isUnique: true, isPrimaryKey: true)
    };
}
