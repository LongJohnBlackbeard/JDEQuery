using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0691261 - .
/// </summary>
public class F0691261 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YLUN.
        /// </summary>
        public const string YLUN = "YLUN";

        /// <summary>
        /// YLMCU.
        /// </summary>
        public const string YLMCU = "YLMCU";

        /// <summary>
        /// YLEFTB.
        /// </summary>
        public const string YLEFTB = "YLEFTB";

        /// <summary>
        /// YLEFTE.
        /// </summary>
        public const string YLEFTE = "YLEFTE";

        /// <summary>
        /// YLJBCD.
        /// </summary>
        public const string YLJBCD = "YLJBCD";

        /// <summary>
        /// YLJBST.
        /// </summary>
        public const string YLJBST = "YLJBST";

        /// <summary>
        /// YLSHFT.
        /// </summary>
        public const string YLSHFT = "YLSHFT";

        /// <summary>
        /// YLPWCF.
        /// </summary>
        public const string YLPWCF = "YLPWCF";

        /// <summary>
        /// YLURCH01.
        /// </summary>
        public const string YLURCH01 = "YLURCH01";

        /// <summary>
        /// YLURCH02.
        /// </summary>
        public const string YLURCH02 = "YLURCH02";

        /// <summary>
        /// YLURCH03.
        /// </summary>
        public const string YLURCH03 = "YLURCH03";

        /// <summary>
        /// YLURCH04.
        /// </summary>
        public const string YLURCH04 = "YLURCH04";

        /// <summary>
        /// YLURMN01.
        /// </summary>
        public const string YLURMN01 = "YLURMN01";

        /// <summary>
        /// YLURMN02.
        /// </summary>
        public const string YLURMN02 = "YLURMN02";

        /// <summary>
        /// YLURMN03.
        /// </summary>
        public const string YLURMN03 = "YLURMN03";

        /// <summary>
        /// YLURMN04.
        /// </summary>
        public const string YLURMN04 = "YLURMN04";

        /// <summary>
        /// YLURST01.
        /// </summary>
        public const string YLURST01 = "YLURST01";

        /// <summary>
        /// YLURST02.
        /// </summary>
        public const string YLURST02 = "YLURST02";

        /// <summary>
        /// YLURST03.
        /// </summary>
        public const string YLURST03 = "YLURST03";

        /// <summary>
        /// YLURST04.
        /// </summary>
        public const string YLURST04 = "YLURST04";

        /// <summary>
        /// YLUSER.
        /// </summary>
        public const string YLUSER = "YLUSER";

        /// <summary>
        /// YLPID.
        /// </summary>
        public const string YLPID = "YLPID";

        /// <summary>
        /// YLJOBN.
        /// </summary>
        public const string YLJOBN = "YLJOBN";

        /// <summary>
        /// YLUPMJ.
        /// </summary>
        public const string YLUPMJ = "YLUPMJ";

        /// <summary>
        /// YLUPMT.
        /// </summary>
        public const string YLUPMT = "YLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0691261";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YLUN", "YLUN", JdeDataType.String, 12, true, true),
        new JdeField("YLMCU", "YLMCU", JdeDataType.String, 24, true, true),
        new JdeField("YLEFTB", "YLEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("YLEFTE", "YLEFTE", JdeDataType.Numeric),
        new JdeField("YLJBCD", "YLJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YLJBST", "YLJBST", JdeDataType.String, 8, true, true),
        new JdeField("YLSHFT", "YLSHFT", JdeDataType.String, 2, true, true),
        new JdeField("YLPWCF", "YLPWCF", JdeDataType.String, 2),
        new JdeField("YLURCH01", "YLURCH01", JdeDataType.String, 2),
        new JdeField("YLURCH02", "YLURCH02", JdeDataType.String, 2),
        new JdeField("YLURCH03", "YLURCH03", JdeDataType.String, 2),
        new JdeField("YLURCH04", "YLURCH04", JdeDataType.String, 2),
        new JdeField("YLURMN01", "YLURMN01", JdeDataType.Numeric),
        new JdeField("YLURMN02", "YLURMN02", JdeDataType.Numeric),
        new JdeField("YLURMN03", "YLURMN03", JdeDataType.Numeric),
        new JdeField("YLURMN04", "YLURMN04", JdeDataType.Numeric),
        new JdeField("YLURST01", "YLURST01", JdeDataType.String, 40),
        new JdeField("YLURST02", "YLURST02", JdeDataType.String, 40),
        new JdeField("YLURST03", "YLURST03", JdeDataType.String, 80),
        new JdeField("YLURST04", "YLURST04", JdeDataType.String, 80),
        new JdeField("YLUSER", "YLUSER", JdeDataType.String, 20),
        new JdeField("YLPID", "YLPID", JdeDataType.String, 20),
        new JdeField("YLJOBN", "YLJOBN", JdeDataType.String, 20),
        new JdeField("YLUPMJ", "YLUPMJ", JdeDataType.Numeric),
        new JdeField("YLUPMT", "YLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0691261_0", "Primary Key on YLUN, YLMCU, YLSHFT, YLEFTB, YLJBCD, YLJBST", new[] { "YLUN", "YLMCU", "YLSHFT", "YLEFTB", "YLJBCD", "YLJBST" }, isUnique: true, isPrimaryKey: true)
    };
}
