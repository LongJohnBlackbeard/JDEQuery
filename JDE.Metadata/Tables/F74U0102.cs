using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0102 - .
/// </summary>
public class F74U0102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCCO.
        /// </summary>
        public const string VCCO = "VCCO";

        /// <summary>
        /// VCUKVCSR.
        /// </summary>
        public const string VCUKVCSR = "VCUKVCSR";

        /// <summary>
        /// VCUKTSQN.
        /// </summary>
        public const string VCUKTSQN = "VCUKTSQN";

        /// <summary>
        /// VCUKVCTP.
        /// </summary>
        public const string VCUKVCTP = "VCUKVCTP";

        /// <summary>
        /// VCUKVCA.
        /// </summary>
        public const string VCUKVCA = "VCUKVCA";

        /// <summary>
        /// VCUKVCW.
        /// </summary>
        public const string VCUKVCW = "VCUKVCW";

        /// <summary>
        /// VCUKVCO.
        /// </summary>
        public const string VCUKVCO = "VCUKVCO";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCCO", "VCCO", JdeDataType.String, 10, true, true),
        new JdeField("VCUKVCSR", "VCUKVCSR", JdeDataType.String, 20),
        new JdeField("VCUKTSQN", "VCUKTSQN", JdeDataType.String, 20),
        new JdeField("VCUKVCTP", "VCUKVCTP", JdeDataType.String, 20, true, true),
        new JdeField("VCUKVCA", "VCUKVCA", JdeDataType.String, 60),
        new JdeField("VCUKVCW", "VCUKVCW", JdeDataType.Numeric),
        new JdeField("VCUKVCO", "VCUKVCO", JdeDataType.String, 20),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0102_0", "Primary Key on VCCO, VCUKVCTP", new[] { "VCCO", "VCUKVCTP" }, isUnique: true, isPrimaryKey: true)
    };
}
