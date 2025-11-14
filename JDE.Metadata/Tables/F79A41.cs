using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A41 - .
/// </summary>
public class F79A41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KP79AGKPID.
        /// </summary>
        public const string KP79AGKPID = "KP79AGKPID";

        /// <summary>
        /// KP79AGKPCD.
        /// </summary>
        public const string KP79AGKPCD = "KP79AGKPCD";

        /// <summary>
        /// KP79AGKPNM.
        /// </summary>
        public const string KP79AGKPNM = "KP79AGKPNM";

        /// <summary>
        /// KP79ANUMTY.
        /// </summary>
        public const string KP79ANUMTY = "KP79ANUMTY";

        /// <summary>
        /// KP79ANUMAC.
        /// </summary>
        public const string KP79ANUMAC = "KP79ANUMAC";

        /// <summary>
        /// KP79ANUMUM.
        /// </summary>
        public const string KP79ANUMUM = "KP79ANUMUM";

        /// <summary>
        /// KP79ADENTY.
        /// </summary>
        public const string KP79ADENTY = "KP79ADENTY";

        /// <summary>
        /// KP79ADENAC.
        /// </summary>
        public const string KP79ADENAC = "KP79ADENAC";

        /// <summary>
        /// KP79ADENUM.
        /// </summary>
        public const string KP79ADENUM = "KP79ADENUM";

        /// <summary>
        /// KPPID.
        /// </summary>
        public const string KPPID = "KPPID";

        /// <summary>
        /// KPUSER.
        /// </summary>
        public const string KPUSER = "KPUSER";

        /// <summary>
        /// KPJOBN.
        /// </summary>
        public const string KPJOBN = "KPJOBN";

        /// <summary>
        /// KPUPMJ.
        /// </summary>
        public const string KPUPMJ = "KPUPMJ";

        /// <summary>
        /// KPTDAY.
        /// </summary>
        public const string KPTDAY = "KPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KP79AGKPID", "KP79AGKPID", JdeDataType.Numeric, null, true, true),
        new JdeField("KP79AGKPCD", "KP79AGKPCD", JdeDataType.String, 120),
        new JdeField("KP79AGKPNM", "KP79AGKPNM", JdeDataType.String, 200),
        new JdeField("KP79ANUMTY", "KP79ANUMTY", JdeDataType.String, 20),
        new JdeField("KP79ANUMAC", "KP79ANUMAC", JdeDataType.String, 20),
        new JdeField("KP79ANUMUM", "KP79ANUMUM", JdeDataType.String, 50),
        new JdeField("KP79ADENTY", "KP79ADENTY", JdeDataType.String, 20),
        new JdeField("KP79ADENAC", "KP79ADENAC", JdeDataType.String, 20),
        new JdeField("KP79ADENUM", "KP79ADENUM", JdeDataType.String, 50),
        new JdeField("KPPID", "KPPID", JdeDataType.String, 20),
        new JdeField("KPUSER", "KPUSER", JdeDataType.String, 20),
        new JdeField("KPJOBN", "KPJOBN", JdeDataType.String, 20),
        new JdeField("KPUPMJ", "KPUPMJ", JdeDataType.Numeric),
        new JdeField("KPTDAY", "KPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A41_0", "Primary Key on KP79AGKPID", new[] { "KP79AGKPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A41_2", "Unique Index on KP79AGKPCD", new[] { "KP79AGKPCD" }, isUnique: true)
    };
}
