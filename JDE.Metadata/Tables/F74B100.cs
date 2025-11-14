using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74B100 - .
/// </summary>
public class F74B100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTTXA1.
        /// </summary>
        public const string BTTXA1 = "BTTXA1";

        /// <summary>
        /// BTDCT.
        /// </summary>
        public const string BTDCT = "BTDCT";

        /// <summary>
        /// BTLNID.
        /// </summary>
        public const string BTLNID = "BTLNID";

        /// <summary>
        /// BTCRDB.
        /// </summary>
        public const string BTCRDB = "BTCRDB";

        /// <summary>
        /// BTITM.
        /// </summary>
        public const string BTITM = "BTITM";

        /// <summary>
        /// BTBEVATCD.
        /// </summary>
        public const string BTBEVATCD = "BTBEVATCD";

        /// <summary>
        /// BTBETACD.
        /// </summary>
        public const string BTBETACD = "BTBETACD";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTUPMT.
        /// </summary>
        public const string BTUPMT = "BTUPMT";

        /// <summary>
        /// BTJOBN.
        /// </summary>
        public const string BTJOBN = "BTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74B100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTTXA1", "BTTXA1", JdeDataType.String, 20, true, true),
        new JdeField("BTDCT", "BTDCT", JdeDataType.String, 4, true, true),
        new JdeField("BTLNID", "BTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BTCRDB", "BTCRDB", JdeDataType.String, 2, true, true),
        new JdeField("BTITM", "BTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BTBEVATCD", "BTBEVATCD", JdeDataType.Numeric),
        new JdeField("BTBETACD", "BTBETACD", JdeDataType.String, 2),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTUPMT", "BTUPMT", JdeDataType.Numeric),
        new JdeField("BTJOBN", "BTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74B100_0", "Primary Key on BTTXA1, BTDCT, BTLNID, BTCRDB, BTITM", new[] { "BTTXA1", "BTDCT", "BTLNID", "BTCRDB", "BTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
