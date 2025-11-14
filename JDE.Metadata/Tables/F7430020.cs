using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430020 - .
/// </summary>
public class F7430020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HA74MDT.
        /// </summary>
        public const string HA74MDT = "HA74MDT";

        /// <summary>
        /// HA74AMDS.
        /// </summary>
        public const string HA74AMDS = "HA74AMDS";

        /// <summary>
        /// HA74AMDD.
        /// </summary>
        public const string HA74AMDD = "HA74AMDD";

        /// <summary>
        /// HA74MDTID.
        /// </summary>
        public const string HA74MDTID = "HA74MDTID";

        /// <summary>
        /// HA74CDTID.
        /// </summary>
        public const string HA74CDTID = "HA74CDTID";

        /// <summary>
        /// HA74CDN.
        /// </summary>
        public const string HA74CDN = "HA74CDN";

        /// <summary>
        /// HA74DBI.
        /// </summary>
        public const string HA74DBI = "HA74DBI";

        /// <summary>
        /// HA74DBB.
        /// </summary>
        public const string HA74DBB = "HA74DBB";

        /// <summary>
        /// HA74AIDD.
        /// </summary>
        public const string HA74AIDD = "HA74AIDD";

        /// <summary>
        /// HA74UAND.
        /// </summary>
        public const string HA74UAND = "HA74UAND";

        /// <summary>
        /// HAUSER.
        /// </summary>
        public const string HAUSER = "HAUSER";

        /// <summary>
        /// HAPID.
        /// </summary>
        public const string HAPID = "HAPID";

        /// <summary>
        /// HAJOBN.
        /// </summary>
        public const string HAJOBN = "HAJOBN";

        /// <summary>
        /// HAUPMT.
        /// </summary>
        public const string HAUPMT = "HAUPMT";

        /// <summary>
        /// HAUPDJ.
        /// </summary>
        public const string HAUPDJ = "HAUPDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7430020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HA74MDT", "HA74MDT", JdeDataType.Numeric, null, true, true),
        new JdeField("HA74AMDS", "HA74AMDS", JdeDataType.Numeric, null, true, true),
        new JdeField("HA74AMDD", "HA74AMDD", JdeDataType.Numeric),
        new JdeField("HA74MDTID", "HA74MDTID", JdeDataType.String, 70),
        new JdeField("HA74CDTID", "HA74CDTID", JdeDataType.String, 70),
        new JdeField("HA74CDN", "HA74CDN", JdeDataType.String, 80),
        new JdeField("HA74DBI", "HA74DBI", JdeDataType.String, 68),
        new JdeField("HA74DBB", "HA74DBB", JdeDataType.String, 30),
        new JdeField("HA74AIDD", "HA74AIDD", JdeDataType.String, 16),
        new JdeField("HA74UAND", "HA74UAND", JdeDataType.Numeric),
        new JdeField("HAUSER", "HAUSER", JdeDataType.String, 20),
        new JdeField("HAPID", "HAPID", JdeDataType.String, 20),
        new JdeField("HAJOBN", "HAJOBN", JdeDataType.String, 20),
        new JdeField("HAUPMT", "HAUPMT", JdeDataType.Numeric),
        new JdeField("HAUPDJ", "HAUPDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430020_0", "Primary Key on HA74MDT, HA74AMDS", new[] { "HA74MDT", "HA74AMDS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7430020_2", "Index on SYS_NC00016$, SYS_NC00017$", new[] { "SYS_NC00016$", "SYS_NC00017$" })
    };
}
