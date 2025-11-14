using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T05 - .
/// </summary>
public class F49T05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OROTDOMAIN.
        /// </summary>
        public const string OROTDOMAIN = "OROTDOMAIN";

        /// <summary>
        /// OROTGENKEY.
        /// </summary>
        public const string OROTGENKEY = "OROTGENKEY";

        /// <summary>
        /// OROBNM.
        /// </summary>
        public const string OROBNM = "OROBNM";

        /// <summary>
        /// ORPEID.
        /// </summary>
        public const string ORPEID = "ORPEID";

        /// <summary>
        /// ORTCID.
        /// </summary>
        public const string ORTCID = "ORTCID";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORUUPMJ.
        /// </summary>
        public const string ORUUPMJ = "ORUUPMJ";

        /// <summary>
        /// ORJOBN.
        /// </summary>
        public const string ORJOBN = "ORJOBN";

        /// <summary>
        /// ORTORG.
        /// </summary>
        public const string ORTORG = "ORTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F49T05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OROTDOMAIN", "OROTDOMAIN", JdeDataType.String, 100, true, true),
        new JdeField("OROTGENKEY", "OROTGENKEY", JdeDataType.String, 100, true, true),
        new JdeField("OROBNM", "OROBNM", JdeDataType.String, 20),
        new JdeField("ORPEID", "ORPEID", JdeDataType.Numeric),
        new JdeField("ORTCID", "ORTCID", JdeDataType.Numeric),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORUUPMJ", "ORUUPMJ", JdeDataType.Date),
        new JdeField("ORJOBN", "ORJOBN", JdeDataType.String, 20),
        new JdeField("ORTORG", "ORTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T05_0", "Primary Key on OROTDOMAIN, OROTGENKEY", new[] { "OROTDOMAIN", "OROTGENKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
