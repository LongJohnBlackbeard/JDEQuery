using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07601 - .
/// </summary>
public class F07601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSLTTP.
        /// </summary>
        public const string LSLTTP = "LSLTTP";

        /// <summary>
        /// LSACCT.
        /// </summary>
        public const string LSACCT = "LSACCT";

        /// <summary>
        /// LSPTL1.
        /// </summary>
        public const string LSPTL1 = "LSPTL1";

        /// <summary>
        /// LSPTL2.
        /// </summary>
        public const string LSPTL2 = "LSPTL2";

        /// <summary>
        /// LSPTL3.
        /// </summary>
        public const string LSPTL3 = "LSPTL3";

        /// <summary>
        /// LSLDSS.
        /// </summary>
        public const string LSLDSS = "LSLDSS";

        /// <summary>
        /// LSFMMB.
        /// </summary>
        public const string LSFMMB = "LSFMMB";

        /// <summary>
        /// LSTCCS.
        /// </summary>
        public const string LSTCCS = "LSTCCS";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSJOBN.
        /// </summary>
        public const string LSJOBN = "LSJOBN";

        /// <summary>
        /// LSUPMT.
        /// </summary>
        public const string LSUPMT = "LSUPMT";

        /// <summary>
        /// LSUPMJ.
        /// </summary>
        public const string LSUPMJ = "LSUPMJ";

        /// <summary>
        /// LSSVH.
        /// </summary>
        public const string LSSVH = "LSSVH";

        /// <summary>
        /// LSRABAL.
        /// </summary>
        public const string LSRABAL = "LSRABAL";
    }

    /// <inheritdoc />
    public override string TableName => "F07601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSLTTP", "LSLTTP", JdeDataType.String, 4, true, true),
        new JdeField("LSACCT", "LSACCT", JdeDataType.String, 2),
        new JdeField("LSPTL1", "LSPTL1", JdeDataType.Numeric),
        new JdeField("LSPTL2", "LSPTL2", JdeDataType.Numeric),
        new JdeField("LSPTL3", "LSPTL3", JdeDataType.Numeric),
        new JdeField("LSLDSS", "LSLDSS", JdeDataType.Numeric),
        new JdeField("LSFMMB", "LSFMMB", JdeDataType.String, 2),
        new JdeField("LSTCCS", "LSTCCS", JdeDataType.String, 2),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSJOBN", "LSJOBN", JdeDataType.String, 20),
        new JdeField("LSUPMT", "LSUPMT", JdeDataType.Numeric),
        new JdeField("LSUPMJ", "LSUPMJ", JdeDataType.Numeric),
        new JdeField("LSSVH", "LSSVH", JdeDataType.String, 2),
        new JdeField("LSRABAL", "LSRABAL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07601_0", "Primary Key on LSLTTP", new[] { "LSLTTP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07601_2", "Index on LSLDSS", new[] { "LSLDSS" }),
        new JdeIndex("F07601_3", "Index on LSFMMB", new[] { "LSFMMB" })
    };
}
