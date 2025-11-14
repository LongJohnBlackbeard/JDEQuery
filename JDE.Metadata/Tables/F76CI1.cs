using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CI1 - .
/// </summary>
public class F76CI1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PITXSY.
        /// </summary>
        public const string PITXSY = "PITXSY";

        /// <summary>
        /// PICCTC.
        /// </summary>
        public const string PICCTC = "PICCTC";

        /// <summary>
        /// PICSTC.
        /// </summary>
        public const string PICSTC = "PICSTC";

        /// <summary>
        /// PICTTY.
        /// </summary>
        public const string PICTTY = "PICTTY";

        /// <summary>
        /// PIEFDJ.
        /// </summary>
        public const string PIEFDJ = "PIEFDJ";

        /// <summary>
        /// PIEFTJ.
        /// </summary>
        public const string PIEFTJ = "PIEFTJ";

        /// <summary>
        /// PIDL01.
        /// </summary>
        public const string PIDL01 = "PIDL01";

        /// <summary>
        /// PICTXF.
        /// </summary>
        public const string PICTXF = "PICTXF";

        /// <summary>
        /// PICMVF.
        /// </summary>
        public const string PICMVF = "PICMVF";

        /// <summary>
        /// PICEAF.
        /// </summary>
        public const string PICEAF = "PICEAF";

        /// <summary>
        /// PITXR1.
        /// </summary>
        public const string PITXR1 = "PITXR1";

        /// <summary>
        /// PICPTT.
        /// </summary>
        public const string PICPTT = "PICPTT";

        /// <summary>
        /// PITLR1.
        /// </summary>
        public const string PITLR1 = "PITLR1";

        /// <summary>
        /// PIMTAX.
        /// </summary>
        public const string PIMTAX = "PIMTAX";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F76CI1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PITXSY", "PITXSY", JdeDataType.String, 2, true, true),
        new JdeField("PICCTC", "PICCTC", JdeDataType.String, 2, true, true),
        new JdeField("PICSTC", "PICSTC", JdeDataType.String, 2, true, true),
        new JdeField("PICTTY", "PICTTY", JdeDataType.String, 4, true, true),
        new JdeField("PIEFDJ", "PIEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIEFTJ", "PIEFTJ", JdeDataType.Numeric),
        new JdeField("PIDL01", "PIDL01", JdeDataType.String, 60),
        new JdeField("PICTXF", "PICTXF", JdeDataType.String, 2),
        new JdeField("PICMVF", "PICMVF", JdeDataType.String, 2),
        new JdeField("PICEAF", "PICEAF", JdeDataType.String, 2),
        new JdeField("PITXR1", "PITXR1", JdeDataType.Numeric),
        new JdeField("PICPTT", "PICPTT", JdeDataType.String, 4),
        new JdeField("PITLR1", "PITLR1", JdeDataType.Numeric),
        new JdeField("PIMTAX", "PIMTAX", JdeDataType.Numeric),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CI1_0", "Primary Key on PITXSY, PICCTC, PICSTC, PICTTY, PIEFDJ", new[] { "PITXSY", "PICCTC", "PICSTC", "PICTTY", "PIEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
