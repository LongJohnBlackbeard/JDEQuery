using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R060 - .
/// </summary>
public class F46R060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPEPCHDR.
        /// </summary>
        public const string EPEPCHDR = "EPEPCHDR";

        /// <summary>
        /// EPEPCPVAL.
        /// </summary>
        public const string EPEPCPVAL = "EPEPCPVAL";

        /// <summary>
        /// EPEPCCPB.
        /// </summary>
        public const string EPEPCCPB = "EPEPCCPB";

        /// <summary>
        /// EPEPCCPD.
        /// </summary>
        public const string EPEPCCPD = "EPEPCCPD";

        /// <summary>
        /// EPEPCPRB.
        /// </summary>
        public const string EPEPCPRB = "EPEPCPRB";

        /// <summary>
        /// EPEPCPRD.
        /// </summary>
        public const string EPEPCPRD = "EPEPCPRD";

        /// <summary>
        /// EPURCD.
        /// </summary>
        public const string EPURCD = "EPURCD";

        /// <summary>
        /// EPURDT.
        /// </summary>
        public const string EPURDT = "EPURDT";

        /// <summary>
        /// EPURAT.
        /// </summary>
        public const string EPURAT = "EPURAT";

        /// <summary>
        /// EPURAB.
        /// </summary>
        public const string EPURAB = "EPURAB";

        /// <summary>
        /// EPURRF.
        /// </summary>
        public const string EPURRF = "EPURRF";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPUUPMJ.
        /// </summary>
        public const string EPUUPMJ = "EPUUPMJ";

        /// <summary>
        /// EPMKEY.
        /// </summary>
        public const string EPMKEY = "EPMKEY";

        /// <summary>
        /// EPSVRNAME.
        /// </summary>
        public const string EPSVRNAME = "EPSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46R060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPEPCHDR", "EPEPCHDR", JdeDataType.String, 4, true, true),
        new JdeField("EPEPCPVAL", "EPEPCPVAL", JdeDataType.Numeric, null, true, true),
        new JdeField("EPEPCCPB", "EPEPCCPB", JdeDataType.Numeric),
        new JdeField("EPEPCCPD", "EPEPCCPD", JdeDataType.Numeric),
        new JdeField("EPEPCPRB", "EPEPCPRB", JdeDataType.Numeric),
        new JdeField("EPEPCPRD", "EPEPCPRD", JdeDataType.Numeric),
        new JdeField("EPURCD", "EPURCD", JdeDataType.String, 4),
        new JdeField("EPURDT", "EPURDT", JdeDataType.Numeric),
        new JdeField("EPURAT", "EPURAT", JdeDataType.Numeric),
        new JdeField("EPURAB", "EPURAB", JdeDataType.Numeric),
        new JdeField("EPURRF", "EPURRF", JdeDataType.String, 30),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPUUPMJ", "EPUUPMJ", JdeDataType.Date),
        new JdeField("EPMKEY", "EPMKEY", JdeDataType.String, 30),
        new JdeField("EPSVRNAME", "EPSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R060_0", "Primary Key on EPEPCHDR, EPEPCPVAL", new[] { "EPEPCHDR", "EPEPCPVAL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46R060_1", "Index on EPEPCHDR, EPEPCCPD", new[] { "EPEPCHDR", "EPEPCCPD" })
    };
}
