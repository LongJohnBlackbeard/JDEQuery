using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA24D - .
/// </summary>
public class F90CA24D : JdeTable
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
        /// SKMMTPNAME.
        /// </summary>
        public const string SKMMTPNAME = "SKMMTPNAME";

        /// <summary>
        /// SKSEQUENCEN.
        /// </summary>
        public const string SKSEQUENCEN = "SKSEQUENCEN";

        /// <summary>
        /// SKDTALTKEY.
        /// </summary>
        public const string SKDTALTKEY = "SKDTALTKEY";

        /// <summary>
        /// SKDTALTVAL.
        /// </summary>
        public const string SKDTALTVAL = "SKDTALTVAL";

        /// <summary>
        /// SKKY.
        /// </summary>
        public const string SKKY = "SKKY";

        /// <summary>
        /// SKMMVERS.
        /// </summary>
        public const string SKMMVERS = "SKMMVERS";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA24D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SKMMTMPI", "SKMMTMPI", JdeDataType.String, 20, true, true),
        new JdeField("SKMMTPNAME", "SKMMTPNAME", JdeDataType.String, 60, true, true),
        new JdeField("SKSEQUENCEN", "SKSEQUENCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("SKDTALTKEY", "SKDTALTKEY", JdeDataType.String, 50, true, true),
        new JdeField("SKDTALTVAL", "SKDTALTVAL", JdeDataType.String, 50, true, true),
        new JdeField("SKKY", "SKKY", JdeDataType.String, 20),
        new JdeField("SKMMVERS", "SKMMVERS", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA24D_0", "Primary Key on SKMMTMPI, SKMMTPNAME, SKSEQUENCEN, SKDTALTKEY, SKDTALTVAL", new[] { "SKMMTMPI", "SKMMTPNAME", "SKSEQUENCEN", "SKDTALTKEY", "SKDTALTVAL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA24D_2", "Index on SKMMTPNAME, SKDTALTKEY, SKDTALTVAL, SKKY", new[] { "SKMMTPNAME", "SKDTALTKEY", "SKDTALTVAL", "SKKY" }),
        new JdeIndex("F90CA24D_3", "Index on SKMMTPNAME, SKDTALTKEY, SKDTALTVAL", new[] { "SKMMTPNAME", "SKDTALTKEY", "SKDTALTVAL" })
    };
}
