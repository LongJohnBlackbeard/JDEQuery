using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L011 - .
/// </summary>
public class FF30L011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDFSCID.
        /// </summary>
        public const string LDFSCID = "LDFSCID";

        /// <summary>
        /// LDDFEPH.
        /// </summary>
        public const string LDDFEPH = "LDDFEPH";

        /// <summary>
        /// LDNUMSHFD.
        /// </summary>
        public const string LDNUMSHFD = "LDNUMSHFD";

        /// <summary>
        /// LDDFWCU.
        /// </summary>
        public const string LDDFWCU = "LDDFWCU";

        /// <summary>
        /// LDDFSEQ.
        /// </summary>
        public const string LDDFSEQ = "LDDFSEQ";

        /// <summary>
        /// LDDFSEQI.
        /// </summary>
        public const string LDDFSEQI = "LDDFSEQI";

        /// <summary>
        /// LDDFOP.
        /// </summary>
        public const string LDDFOP = "LDDFOP";

        /// <summary>
        /// LDDFOPI.
        /// </summary>
        public const string LDDFOPI = "LDDFOPI";

        /// <summary>
        /// LDDFOPT.
        /// </summary>
        public const string LDDFOPT = "LDDFOPT";

        /// <summary>
        /// LDUDLDEF1.
        /// </summary>
        public const string LDUDLDEF1 = "LDUDLDEF1";

        /// <summary>
        /// LDUDLDEF2.
        /// </summary>
        public const string LDUDLDEF2 = "LDUDLDEF2";

        /// <summary>
        /// LDUDLDEF3.
        /// </summary>
        public const string LDUDLDEF3 = "LDUDLDEF3";

        /// <summary>
        /// LDUDLDEF4.
        /// </summary>
        public const string LDUDLDEF4 = "LDUDLDEF4";

        /// <summary>
        /// LDUDLDEF5.
        /// </summary>
        public const string LDUDLDEF5 = "LDUDLDEF5";

        /// <summary>
        /// LDUDLDEF6.
        /// </summary>
        public const string LDUDLDEF6 = "LDUDLDEF6";

        /// <summary>
        /// LDUDLDEF7.
        /// </summary>
        public const string LDUDLDEF7 = "LDUDLDEF7";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDMKEY.
        /// </summary>
        public const string LDMKEY = "LDMKEY";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDUUPMJ.
        /// </summary>
        public const string LDUUPMJ = "LDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDFSCID", "LDFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDDFEPH", "LDDFEPH", JdeDataType.Numeric),
        new JdeField("LDNUMSHFD", "LDNUMSHFD", JdeDataType.Numeric),
        new JdeField("LDDFWCU", "LDDFWCU", JdeDataType.String, 2),
        new JdeField("LDDFSEQ", "LDDFSEQ", JdeDataType.Numeric),
        new JdeField("LDDFSEQI", "LDDFSEQI", JdeDataType.Numeric),
        new JdeField("LDDFOP", "LDDFOP", JdeDataType.Numeric),
        new JdeField("LDDFOPI", "LDDFOPI", JdeDataType.Numeric),
        new JdeField("LDDFOPT", "LDDFOPT", JdeDataType.Numeric),
        new JdeField("LDUDLDEF1", "LDUDLDEF1", JdeDataType.String, 60),
        new JdeField("LDUDLDEF2", "LDUDLDEF2", JdeDataType.String, 60),
        new JdeField("LDUDLDEF3", "LDUDLDEF3", JdeDataType.String, 60),
        new JdeField("LDUDLDEF4", "LDUDLDEF4", JdeDataType.String, 60),
        new JdeField("LDUDLDEF5", "LDUDLDEF5", JdeDataType.String, 60),
        new JdeField("LDUDLDEF6", "LDUDLDEF6", JdeDataType.String, 60),
        new JdeField("LDUDLDEF7", "LDUDLDEF7", JdeDataType.String, 60),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDMKEY", "LDMKEY", JdeDataType.String, 30),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDUUPMJ", "LDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L011_0", "Primary Key on LDFSCID", new[] { "LDFSCID" }, isUnique: true, isPrimaryKey: true)
    };
}
