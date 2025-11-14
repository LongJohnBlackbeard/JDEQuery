using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05601 - .
/// </summary>
public class F05601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPBASP.
        /// </summary>
        public const string CPBASP = "CPBASP";

        /// <summary>
        /// CPCPPT.
        /// </summary>
        public const string CPCPPT = "CPCPPT";

        /// <summary>
        /// CPEFTB.
        /// </summary>
        public const string CPEFTB = "CPEFTB";

        /// <summary>
        /// CPEFTE.
        /// </summary>
        public const string CPEFTE = "CPEFTE";

        /// <summary>
        /// CPCMED.
        /// </summary>
        public const string CPCMED = "CPCMED";

        /// <summary>
        /// CPCOPR.
        /// </summary>
        public const string CPCOPR = "CPCOPR";

        /// <summary>
        /// CPDTAB.
        /// </summary>
        public const string CPDTAB = "CPDTAB";

        /// <summary>
        /// CPOVBU.
        /// </summary>
        public const string CPOVBU = "CPOVBU";

        /// <summary>
        /// CPOVOB.
        /// </summary>
        public const string CPOVOB = "CPOVOB";

        /// <summary>
        /// CPOVSB.
        /// </summary>
        public const string CPOVSB = "CPOVSB";

        /// <summary>
        /// CPAAIBU.
        /// </summary>
        public const string CPAAIBU = "CPAAIBU";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPBASP", "CPBASP", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCPPT", "CPCPPT", JdeDataType.Numeric, null, true, true),
        new JdeField("CPEFTB", "CPEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("CPEFTE", "CPEFTE", JdeDataType.Numeric),
        new JdeField("CPCMED", "CPCMED", JdeDataType.String, 2),
        new JdeField("CPCOPR", "CPCOPR", JdeDataType.Numeric),
        new JdeField("CPDTAB", "CPDTAB", JdeDataType.String, 10),
        new JdeField("CPOVBU", "CPOVBU", JdeDataType.String, 2),
        new JdeField("CPOVOB", "CPOVOB", JdeDataType.String, 2),
        new JdeField("CPOVSB", "CPOVSB", JdeDataType.String, 2),
        new JdeField("CPAAIBU", "CPAAIBU", JdeDataType.String, 2),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05601_0", "Primary Key on CPBASP, CPCPPT, CPEFTB", new[] { "CPBASP", "CPCPPT", "CPEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
