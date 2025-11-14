using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7308 - .
/// </summary>
public class F7308 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VGVDBKY.
        /// </summary>
        public const string VGVDBKY = "VGVDBKY";

        /// <summary>
        /// VGVTDSRC.
        /// </summary>
        public const string VGVTDSRC = "VGVTDSRC";

        /// <summary>
        /// VGVTSRV.
        /// </summary>
        public const string VGVTSRV = "VGVTSRV";

        /// <summary>
        /// VGVTUSR.
        /// </summary>
        public const string VGVTUSR = "VGVTUSR";

        /// <summary>
        /// VGVTPWD.
        /// </summary>
        public const string VGVTPWD = "VGVTPWD";
    }

    /// <inheritdoc />
    public override string TableName => "F7308";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VGVDBKY", "VGVDBKY", JdeDataType.String, 4, true, true),
        new JdeField("VGVTDSRC", "VGVTDSRC", JdeDataType.String, 508),
        new JdeField("VGVTSRV", "VGVTSRV", JdeDataType.String, 160),
        new JdeField("VGVTUSR", "VGVTUSR", JdeDataType.String, 160),
        new JdeField("VGVTPWD", "VGVTPWD", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7308_0", "Primary Key on VGVDBKY", new[] { "VGVDBKY" }, isUnique: true, isPrimaryKey: true)
    };
}
