using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA24E - .
/// </summary>
public class F90CA24E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SKMMTMPI.
        /// </summary>
        public const string SKMMTMPI = "SKMMTMPI";

        /// <summary>
        /// SKDTALTKEY.
        /// </summary>
        public const string SKDTALTKEY = "SKDTALTKEY";

        /// <summary>
        /// SKDTALTVAL.
        /// </summary>
        public const string SKDTALTVAL = "SKDTALTVAL";

        /// <summary>
        /// SKLNGP.
        /// </summary>
        public const string SKLNGP = "SKLNGP";

        /// <summary>
        /// SKMMVERS.
        /// </summary>
        public const string SKMMVERS = "SKMMVERS";

        /// <summary>
        /// SKSEQUENCEN.
        /// </summary>
        public const string SKSEQUENCEN = "SKSEQUENCEN";

        /// <summary>
        /// SKUSER.
        /// </summary>
        public const string SKUSER = "SKUSER";

        /// <summary>
        /// SKPID.
        /// </summary>
        public const string SKPID = "SKPID";

        /// <summary>
        /// SKVID.
        /// </summary>
        public const string SKVID = "SKVID";

        /// <summary>
        /// SKMKEY.
        /// </summary>
        public const string SKMKEY = "SKMKEY";

        /// <summary>
        /// SKUDTTM.
        /// </summary>
        public const string SKUDTTM = "SKUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA24E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SKMMTMPI", "SKMMTMPI", JdeDataType.String, 20, true, true),
        new JdeField("SKDTALTKEY", "SKDTALTKEY", JdeDataType.String, 50, true, true),
        new JdeField("SKDTALTVAL", "SKDTALTVAL", JdeDataType.String, 50, true, true),
        new JdeField("SKLNGP", "SKLNGP", JdeDataType.String, 4, true, true),
        new JdeField("SKMMVERS", "SKMMVERS", JdeDataType.String, 60),
        new JdeField("SKSEQUENCEN", "SKSEQUENCEN", JdeDataType.Numeric),
        new JdeField("SKUSER", "SKUSER", JdeDataType.String, 20),
        new JdeField("SKPID", "SKPID", JdeDataType.String, 20),
        new JdeField("SKVID", "SKVID", JdeDataType.String, 20),
        new JdeField("SKMKEY", "SKMKEY", JdeDataType.String, 30),
        new JdeField("SKUDTTM", "SKUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA24E_0", "Primary Key on SKMMTMPI, SKDTALTKEY, SKDTALTVAL, SKLNGP", new[] { "SKMMTMPI", "SKDTALTKEY", "SKDTALTVAL", "SKLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
