using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09523 - .
/// </summary>
public class F09523 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSRSTRUC.
        /// </summary>
        public const string FSRSTRUC = "FSRSTRUC";

        /// <summary>
        /// FSCHDCSH.
        /// </summary>
        public const string FSCHDCSH = "FSCHDCSH";

        /// <summary>
        /// FSPNTCSH.
        /// </summary>
        public const string FSPNTCSH = "FSPNTCSH";

        /// <summary>
        /// FSLEVEL.
        /// </summary>
        public const string FSLEVEL = "FSLEVEL";

        /// <summary>
        /// FSSEQUEN.
        /// </summary>
        public const string FSSEQUEN = "FSSEQUEN";

        /// <summary>
        /// FSDL01.
        /// </summary>
        public const string FSDL01 = "FSDL01";

        /// <summary>
        /// FSCFDTE1.
        /// </summary>
        public const string FSCFDTE1 = "FSCFDTE1";

        /// <summary>
        /// FSCFFLG2.
        /// </summary>
        public const string FSCFFLG2 = "FSCFFLG2";

        /// <summary>
        /// FSCFDSC3.
        /// </summary>
        public const string FSCFDSC3 = "FSCFDSC3";

        /// <summary>
        /// FSCFNO4.
        /// </summary>
        public const string FSCFNO4 = "FSCFNO4";

        /// <summary>
        /// FSCFSTR5.
        /// </summary>
        public const string FSCFSTR5 = "FSCFSTR5";

        /// <summary>
        /// FSPID.
        /// </summary>
        public const string FSPID = "FSPID";

        /// <summary>
        /// FSJOBN.
        /// </summary>
        public const string FSJOBN = "FSJOBN";

        /// <summary>
        /// FSUSER.
        /// </summary>
        public const string FSUSER = "FSUSER";

        /// <summary>
        /// FSUPMT.
        /// </summary>
        public const string FSUPMT = "FSUPMT";

        /// <summary>
        /// FSUPMJ.
        /// </summary>
        public const string FSUPMJ = "FSUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09523";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSRSTRUC", "FSRSTRUC", JdeDataType.String, 20, true, true),
        new JdeField("FSCHDCSH", "FSCHDCSH", JdeDataType.String, 20, true, true),
        new JdeField("FSPNTCSH", "FSPNTCSH", JdeDataType.String, 20),
        new JdeField("FSLEVEL", "FSLEVEL", JdeDataType.Numeric),
        new JdeField("FSSEQUEN", "FSSEQUEN", JdeDataType.Numeric),
        new JdeField("FSDL01", "FSDL01", JdeDataType.String, 60),
        new JdeField("FSCFDTE1", "FSCFDTE1", JdeDataType.Numeric),
        new JdeField("FSCFFLG2", "FSCFFLG2", JdeDataType.String, 2),
        new JdeField("FSCFDSC3", "FSCFDSC3", JdeDataType.String, 58),
        new JdeField("FSCFNO4", "FSCFNO4", JdeDataType.Numeric),
        new JdeField("FSCFSTR5", "FSCFSTR5", JdeDataType.String, 20),
        new JdeField("FSPID", "FSPID", JdeDataType.String, 20),
        new JdeField("FSJOBN", "FSJOBN", JdeDataType.String, 20),
        new JdeField("FSUSER", "FSUSER", JdeDataType.String, 20),
        new JdeField("FSUPMT", "FSUPMT", JdeDataType.Numeric),
        new JdeField("FSUPMJ", "FSUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09523_0", "Primary Key on FSRSTRUC, FSCHDCSH", new[] { "FSRSTRUC", "FSCHDCSH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09523_3", "Index on FSRSTRUC, FSLEVEL, FSSEQUEN", new[] { "FSRSTRUC", "FSLEVEL", "FSSEQUEN" }),
        new JdeIndex("F09523_4", "Index on FSRSTRUC", new[] { "FSRSTRUC" }),
        new JdeIndex("F09523_6", "Index on FSPNTCSH", new[] { "FSPNTCSH" }),
        new JdeIndex("F09523_7", "Index on FSRSTRUC, FSPNTCSH, SYS_NC00017$", new[] { "FSRSTRUC", "FSPNTCSH", "SYS_NC00017$" }),
        new JdeIndex("F09523_8", "Index on FSRSTRUC, FSPNTCSH, FSSEQUEN", new[] { "FSRSTRUC", "FSPNTCSH", "FSSEQUEN" })
    };
}
