using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48301 - .
/// </summary>
public class F48301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RXMCU.
        /// </summary>
        public const string RXMCU = "RXMCU";

        /// <summary>
        /// RXMMCU.
        /// </summary>
        public const string RXMMCU = "RXMMCU";

        /// <summary>
        /// RXWDCT.
        /// </summary>
        public const string RXWDCT = "RXWDCT";

        /// <summary>
        /// RXWDCK.
        /// </summary>
        public const string RXWDCK = "RXWDCK";

        /// <summary>
        /// RXSHFT.
        /// </summary>
        public const string RXSHFT = "RXSHFT";

        /// <summary>
        /// RXWMCU.
        /// </summary>
        public const string RXWMCU = "RXWMCU";

        /// <summary>
        /// RXWDAYST.
        /// </summary>
        public const string RXWDAYST = "RXWDAYST";

        /// <summary>
        /// RXWDAYET.
        /// </summary>
        public const string RXWDAYET = "RXWDAYET";

        /// <summary>
        /// RXWDAYST2.
        /// </summary>
        public const string RXWDAYST2 = "RXWDAYST2";

        /// <summary>
        /// RXWDAYET2.
        /// </summary>
        public const string RXWDAYET2 = "RXWDAYET2";

        /// <summary>
        /// RXWDAYST3.
        /// </summary>
        public const string RXWDAYST3 = "RXWDAYST3";

        /// <summary>
        /// RXWDAYET3.
        /// </summary>
        public const string RXWDAYET3 = "RXWDAYET3";

        /// <summary>
        /// RXDAVL.
        /// </summary>
        public const string RXDAVL = "RXDAVL";

        /// <summary>
        /// RXFCNM.
        /// </summary>
        public const string RXFCNM = "RXFCNM";

        /// <summary>
        /// RXURCD.
        /// </summary>
        public const string RXURCD = "RXURCD";

        /// <summary>
        /// RXURDT.
        /// </summary>
        public const string RXURDT = "RXURDT";

        /// <summary>
        /// RXURAT.
        /// </summary>
        public const string RXURAT = "RXURAT";

        /// <summary>
        /// RXURAB.
        /// </summary>
        public const string RXURAB = "RXURAB";

        /// <summary>
        /// RXURRF.
        /// </summary>
        public const string RXURRF = "RXURRF";

        /// <summary>
        /// RXUSER.
        /// </summary>
        public const string RXUSER = "RXUSER";

        /// <summary>
        /// RXPID.
        /// </summary>
        public const string RXPID = "RXPID";

        /// <summary>
        /// RXJOBN.
        /// </summary>
        public const string RXJOBN = "RXJOBN";

        /// <summary>
        /// RXUPMJ.
        /// </summary>
        public const string RXUPMJ = "RXUPMJ";

        /// <summary>
        /// RXTDAY.
        /// </summary>
        public const string RXTDAY = "RXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F48301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RXMCU", "RXMCU", JdeDataType.String, 24, true, true),
        new JdeField("RXMMCU", "RXMMCU", JdeDataType.String, 24),
        new JdeField("RXWDCT", "RXWDCT", JdeDataType.String, 20),
        new JdeField("RXWDCK", "RXWDCK", JdeDataType.String, 20),
        new JdeField("RXSHFT", "RXSHFT", JdeDataType.String, 2),
        new JdeField("RXWMCU", "RXWMCU", JdeDataType.String, 24),
        new JdeField("RXWDAYST", "RXWDAYST", JdeDataType.Numeric),
        new JdeField("RXWDAYET", "RXWDAYET", JdeDataType.Numeric),
        new JdeField("RXWDAYST2", "RXWDAYST2", JdeDataType.Numeric),
        new JdeField("RXWDAYET2", "RXWDAYET2", JdeDataType.Numeric),
        new JdeField("RXWDAYST3", "RXWDAYST3", JdeDataType.Numeric),
        new JdeField("RXWDAYET3", "RXWDAYET3", JdeDataType.Numeric),
        new JdeField("RXDAVL", "RXDAVL", JdeDataType.Numeric),
        new JdeField("RXFCNM", "RXFCNM", JdeDataType.String, 64),
        new JdeField("RXURCD", "RXURCD", JdeDataType.String, 4),
        new JdeField("RXURDT", "RXURDT", JdeDataType.Numeric),
        new JdeField("RXURAT", "RXURAT", JdeDataType.Numeric),
        new JdeField("RXURAB", "RXURAB", JdeDataType.Numeric),
        new JdeField("RXURRF", "RXURRF", JdeDataType.String, 30),
        new JdeField("RXUSER", "RXUSER", JdeDataType.String, 20),
        new JdeField("RXPID", "RXPID", JdeDataType.String, 20),
        new JdeField("RXJOBN", "RXJOBN", JdeDataType.String, 20),
        new JdeField("RXUPMJ", "RXUPMJ", JdeDataType.Numeric),
        new JdeField("RXTDAY", "RXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48301_0", "Primary Key on RXMCU", new[] { "RXMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
